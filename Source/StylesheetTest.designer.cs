namespace XMLGridDataProvider
{
    partial class XMLTransformationSettingsDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cancelButton = new System.Windows.Forms.Button();
            this.transformButton = new System.Windows.Forms.Button();
            this.stylesheetLabel = new System.Windows.Forms.Label();
            this.inputFileNameLabel = new System.Windows.Forms.Label();
            this.inputFileNameTextBox = new System.Windows.Forms.TextBox();
            this.inputFileNameBrowseButton = new System.Windows.Forms.Button();
            this.stylesheetFileNameBrowseButton = new System.Windows.Forms.Button();
            this.responseTextBox = new System.Windows.Forms.TextBox();
            this.stylesheetTextBox = new System.Windows.Forms.TextBox();
            this.saveStylesheet = new System.Windows.Forms.Button();
            this.viewTreeButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saveTransformButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(931, 729);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 28);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // transformButton
            // 
            this.transformButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.transformButton.Location = new System.Drawing.Point(583, 729);
            this.transformButton.Margin = new System.Windows.Forms.Padding(4);
            this.transformButton.Name = "transformButton";
            this.transformButton.Size = new System.Drawing.Size(100, 28);
            this.transformButton.TabIndex = 17;
            this.transformButton.Text = "&Transform";
            this.transformButton.UseVisualStyleBackColor = true;
            this.transformButton.Click += new System.EventHandler(this.previewButton_Click);
            // 
            // stylesheetLabel
            // 
            this.stylesheetLabel.AutoSize = true;
            this.stylesheetLabel.Location = new System.Drawing.Point(26, 314);
            this.stylesheetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stylesheetLabel.Name = "stylesheetLabel";
            this.stylesheetLabel.Size = new System.Drawing.Size(73, 16);
            this.stylesheetLabel.TabIndex = 15;
            this.stylesheetLabel.Text = "&Stylesheet:";
            // 
            // inputFileNameLabel
            // 
            this.inputFileNameLabel.AutoSize = true;
            this.inputFileNameLabel.Location = new System.Drawing.Point(20, 18);
            this.inputFileNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inputFileNameLabel.Name = "inputFileNameLabel";
            this.inputFileNameLabel.Size = new System.Drawing.Size(103, 16);
            this.inputFileNameLabel.TabIndex = 18;
            this.inputFileNameLabel.Text = "&Input File Name:";
            // 
            // inputFileNameTextBox
            // 
            this.inputFileNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputFileNameTextBox.Location = new System.Drawing.Point(139, 15);
            this.inputFileNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.inputFileNameTextBox.Name = "inputFileNameTextBox";
            this.inputFileNameTextBox.Size = new System.Drawing.Size(850, 22);
            this.inputFileNameTextBox.TabIndex = 19;
            // 
            // inputFileNameBrowseButton
            // 
            this.inputFileNameBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputFileNameBrowseButton.Location = new System.Drawing.Point(997, 12);
            this.inputFileNameBrowseButton.Margin = new System.Windows.Forms.Padding(4);
            this.inputFileNameBrowseButton.Name = "inputFileNameBrowseButton";
            this.inputFileNameBrowseButton.Size = new System.Drawing.Size(40, 28);
            this.inputFileNameBrowseButton.TabIndex = 20;
            this.inputFileNameBrowseButton.Text = "...";
            this.inputFileNameBrowseButton.UseVisualStyleBackColor = true;
            this.inputFileNameBrowseButton.Click += new System.EventHandler(this.inputFileNameBrowseButton_Click);
            // 
            // stylesheetFileNameBrowseButton
            // 
            this.stylesheetFileNameBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stylesheetFileNameBrowseButton.Location = new System.Drawing.Point(599, 299);
            this.stylesheetFileNameBrowseButton.Margin = new System.Windows.Forms.Padding(4);
            this.stylesheetFileNameBrowseButton.Name = "stylesheetFileNameBrowseButton";
            this.stylesheetFileNameBrowseButton.Size = new System.Drawing.Size(145, 28);
            this.stylesheetFileNameBrowseButton.TabIndex = 21;
            this.stylesheetFileNameBrowseButton.Text = "Load Stylesheet";
            this.stylesheetFileNameBrowseButton.UseVisualStyleBackColor = true;
            this.stylesheetFileNameBrowseButton.Click += new System.EventHandler(this.stylesheetFileNameBrowseButton_Click);
            // 
            // responseTextBox
            // 
            this.responseTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.responseTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.responseTextBox.Location = new System.Drawing.Point(25, 48);
            this.responseTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.responseTextBox.Multiline = true;
            this.responseTextBox.Name = "responseTextBox";
            this.responseTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.responseTextBox.Size = new System.Drawing.Size(1010, 243);
            this.responseTextBox.TabIndex = 23;
            // 
            // stylesheetTextBox
            // 
            this.stylesheetTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stylesheetTextBox.Location = new System.Drawing.Point(25, 335);
            this.stylesheetTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.stylesheetTextBox.Multiline = true;
            this.stylesheetTextBox.Name = "stylesheetTextBox";
            this.stylesheetTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.stylesheetTextBox.Size = new System.Drawing.Size(1010, 260);
            this.stylesheetTextBox.TabIndex = 24;
            // 
            // saveStylesheet
            // 
            this.saveStylesheet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveStylesheet.Location = new System.Drawing.Point(884, 299);
            this.saveStylesheet.Margin = new System.Windows.Forms.Padding(4);
            this.saveStylesheet.Name = "saveStylesheet";
            this.saveStylesheet.Size = new System.Drawing.Size(134, 28);
            this.saveStylesheet.TabIndex = 25;
            this.saveStylesheet.Text = "Save Stylesheet";
            this.saveStylesheet.UseVisualStyleBackColor = true;
            this.saveStylesheet.Click += new System.EventHandler(this.saveStylesheet_Click);
            // 
            // viewTreeButton
            // 
            this.viewTreeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.viewTreeButton.Location = new System.Drawing.Point(823, 729);
            this.viewTreeButton.Margin = new System.Windows.Forms.Padding(4);
            this.viewTreeButton.Name = "viewTreeButton";
            this.viewTreeButton.Size = new System.Drawing.Size(100, 28);
            this.viewTreeButton.TabIndex = 26;
            this.viewTreeButton.Text = "View Tree";
            this.viewTreeButton.UseVisualStyleBackColor = true;
            this.viewTreeButton.Click += new System.EventHandler(this.viewTreeButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(29, 603);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1002, 116);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transformation Results";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 19);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(994, 93);
            this.dataGridView1.TabIndex = 0;
            // 
            // saveTransformButton
            // 
            this.saveTransformButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveTransformButton.Location = new System.Drawing.Point(691, 729);
            this.saveTransformButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveTransformButton.Name = "saveTransformButton";
            this.saveTransformButton.Size = new System.Drawing.Size(124, 28);
            this.saveTransformButton.TabIndex = 37;
            this.saveTransformButton.Text = "Save Transform";
            this.saveTransformButton.UseVisualStyleBackColor = true;
            this.saveTransformButton.Click += new System.EventHandler(this.saveResponseButton_Click);
            // 
            // XMLTransformationSettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(1048, 770);
            this.Controls.Add(this.saveTransformButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.viewTreeButton);
            this.Controls.Add(this.saveStylesheet);
            this.Controls.Add(this.stylesheetTextBox);
            this.Controls.Add(this.responseTextBox);
            this.Controls.Add(this.stylesheetFileNameBrowseButton);
            this.Controls.Add(this.inputFileNameBrowseButton);
            this.Controls.Add(this.inputFileNameLabel);
            this.Controls.Add(this.inputFileNameTextBox);
            this.Controls.Add(this.transformButton);
            this.Controls.Add(this.stylesheetLabel);
            this.Controls.Add(this.cancelButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "XMLTransformationSettingsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stylesheet Test";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button transformButton;
        private System.Windows.Forms.Label stylesheetLabel;
        private System.Windows.Forms.Label inputFileNameLabel;
        private System.Windows.Forms.TextBox inputFileNameTextBox;
        private System.Windows.Forms.Button inputFileNameBrowseButton;
        private System.Windows.Forms.Button stylesheetFileNameBrowseButton;
        private System.Windows.Forms.TextBox responseTextBox;
        private System.Windows.Forms.TextBox stylesheetTextBox;
        private System.Windows.Forms.Button saveStylesheet;
        private System.Windows.Forms.Button viewTreeButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button saveTransformButton;
    }
}