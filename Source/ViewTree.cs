using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StylesheetTest
{
    public partial class ViewTree : Form
    {
        private DataTable _processTable;
        public ViewTree(DataSet ds)
        {
            InitializeComponent();

            _processTable = ds.Tables[0];

            PopulateTree();

        }

        void PopulateTree()
        {
            try
            {


                foreach (DataRow r in _processTable.Rows)
                {
                    String category = Convert.ToString(r[0]);
                    String processName = Convert.ToString(r[1]);
                    String executeProcessName = Convert.ToString(r[2]);

                    var results = from myRow in _processTable.AsEnumerable()
                                  where myRow.Field<string>("ExecuteProcessName") == processName
                                  select myRow;

                    // Only Export Top Level
                    if (results.Count() == 0 || rootNodesOnly.Checked == false)
                    {
                        TreeNode categoryNode = treeView1.Nodes[category];
                        if (categoryNode == null)
                        {
                            categoryNode = treeView1.Nodes.Add(category, category);
                        }
                        TreeNode processNode = categoryNode.Nodes[processName];
                        if (processNode == null)
                        {
                            processNode = categoryNode.Nodes.Add(processName, processName);
                        }
                        AddExecuteProcessNodes(category, processName, executeProcessName, processNode, 0);

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void AddExecuteProcessNodes(String topCategory, String topProcessName, String executeProcessName, TreeNode parentNode, Int32 level)
        {
            level++;
            if (level < 100)
            {
                executeProcessName = executeProcessName.Trim();
                if (executeProcessName.Length > 0)
                {
                    var childProcessNode = parentNode.Nodes.Add(executeProcessName, executeProcessName);

                    var results = from myRow in _processTable.AsEnumerable()
                                  where myRow.Field<string>("ProcessName") == executeProcessName
                                  select myRow;

                    foreach (DataRow r in results)
                    {
                        String childExecuteProcessName = Convert.ToString(r[2]);
                        childExecuteProcessName = childExecuteProcessName.Trim();
                        if (childExecuteProcessName.Length > 0)
                        {
                            // Only add if node does not exist in parents
                            if (ProcessNameInParentNodes(childExecuteProcessName, parentNode) == false)
                            {
                                AddExecuteProcessNodes(topCategory, topProcessName, childExecuteProcessName, childProcessNode, level);
                            }
                            else
                            {
                                var childchildProcessNode = childProcessNode.Nodes.Add(childExecuteProcessName, childExecuteProcessName);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Level More Than 100 deep for Top Process : " + topProcessName,"Stopped Loading Levels Due To Possible Recursion");
            }
        }

        bool ProcessNameInParentNodes(String executeProcess, TreeNode parentNode)
        {
            bool found = false;

            if (parentNode != null)
            {
                if (parentNode.Name == executeProcess)
                {
                    found = true;
                }
                else
                {
                    found = ProcessNameInParentNodes(executeProcess, parentNode.Parent);
                }
            }

            return found;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }

        private void BuildCSV(TreeNodeCollection nodes, ref string csvData, int depth)
        {

            foreach (TreeNode node in nodes)
            {
                csvData = csvData + new String(',', depth) + node.Text + "\n";
                if (node.Nodes.Count > 0)

                    BuildCSV(node.Nodes, ref csvData, depth + 1);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "CSV Files (*.csv)|*.csv";
            dlg.Title = "Select Export CSV File";

            if (dlg.ShowDialog() == DialogResult.OK)
            {

                string csvData = "";
                BuildCSV(treeView1.Nodes, ref csvData, 0);
                using (StreamWriter writer = new StreamWriter(dlg.FileName))
                {
                    writer.Write(csvData);
                }
            }
        }

        private void rootNodesOnly_CheckedChanged(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            PopulateTree();  
        }
    }
}
