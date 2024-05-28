using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace XMLGridDataProvider
{
    public partial class XMLTransformationSettingsDialog : Form
    {
        private string _stylesheetFileName = "";
        private DataSet _ds;

        public XMLTransformationSettingsDialog()
        {
            InitializeComponent();
            stylesheetTextBox.Text = "<xsl:stylesheet version =\"1.0\" xmlns:xsl=\"http://www.w3.org/1999/XSL/Transform\"><xsl:template match=\"/\"><xsl:copy-of select=\".\"/></xsl:template></xsl:stylesheet>"; ;
        }
        
        private void inputFileNameBrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "XML Files (*.xml)|*.xml";
            dlg.Title = "Select Input File";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                inputFileNameTextBox.Text = dlg.FileName;
                responseTextBox.Text = File.ReadAllText(inputFileNameTextBox.Text);
            }
        }

        private void stylesheetFileNameBrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Stylesheet Files (*.xsl, *xslt)|*.xsl;*.xslt";
            dlg.Title = "Select Stylesheet File";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _stylesheetFileName = dlg.FileName;
                stylesheetTextBox.Text = File.ReadAllText(_stylesheetFileName);
            }
        }

        private void previewButton_Click(object sender, EventArgs e)
        {            
            try
            {
                _ds = XMLTransformationUtils.GetDataSetFromTransform(stylesheetTextBox.Text, responseTextBox.Text);
                if (_ds.Tables.Count > 0) dataGridView1.DataSource = _ds.Tables[0];
                else
                {
                    MessageBox.Show("No Rows Found In Transformation");
                    dataGridView1.DataSource = null;
                }

            }
            catch (Exception ex)
            {
                string errString = String.Format("Error Transforming {0}...{1}", responseTextBox.Text, ex.Message);
                if (errString.Length > 32000) errString = errString.Substring(0, 32000);
                MessageBox.Show(errString);
                dataGridView1.DataSource = null;
            }
        }

        private string beautify(string xml)
        {
            var doc = new XmlDocument();
            doc.LoadXml(xml);

            var settings = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = "\t",
                NewLineChars = Environment.NewLine,
                NewLineHandling = NewLineHandling.Replace,
                Encoding = new UTF8Encoding(false)
            };

            using (var ms = new MemoryStream())
            using (var writer = XmlWriter.Create(ms, settings))
            {
                doc.Save(writer);
                var xmlString = Encoding.UTF8.GetString(ms.ToArray());
                return xmlString;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveStylesheet_Click(object sender, EventArgs e)
        {
            if (stylesheetTextBox.Text.Length > 0)
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "Stylesheet Files (*.xsl, *xslt)|*.xsl;*.xslt";
                dlg.Title = "Select Stylesheet File";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(dlg.FileName, stylesheetTextBox.Text);
                }
            }
        }

        private void viewTreeButton_Click(object sender, EventArgs e)
        {
            if (_ds != null)
            {
                StylesheetTest.ViewTree vt = new StylesheetTest.ViewTree(_ds);
                vt.ShowDialog();
            }
            else
            {
                MessageBox.Show("Datagrid Preview Must Be Populated");
            }
        }

        private void saveResponseButton_Click(object sender, EventArgs e)
        {
            if (_ds != null)
            {
                if (_ds.Tables.Count > 0) 
                {
                    OpenFileDialog dlg = new OpenFileDialog();
                    dlg.Filter = "XML Files (*.xml)|*.xml";
                    dlg.Title = "Select Export File";

                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        _ds.WriteXml(dlg.FileName);
                    }
                }
            }
        }
    }
}
