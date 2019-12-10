namespace FoxProReader
{
    partial class FoxProFileReaderForm
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
            this.tableEdit = new System.Windows.Forms.ComboBox();
            this.tableView = new System.Windows.Forms.DataGridView();
            this.pathEdit = new System.Windows.Forms.MaskedTextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.pathLabel = new System.Windows.Forms.Label();
            this.Table = new System.Windows.Forms.Label();
            this.browserDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableEdit
            // 
            this.tableEdit.FormattingEnabled = true;
            this.tableEdit.Location = new System.Drawing.Point(93, 39);
            this.tableEdit.Name = "tableEdit";
            this.tableEdit.Size = new System.Drawing.Size(521, 21);
            this.tableEdit.TabIndex = 0;
            this.tableEdit.TextChanged += new System.EventHandler(this.tableEdit_TextChanged);
            // 
            // tableView
            // 
            this.tableView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableView.Location = new System.Drawing.Point(2, 66);
            this.tableView.Name = "tableView";
            this.tableView.Size = new System.Drawing.Size(786, 380);
            this.tableView.TabIndex = 2;
            // 
            // pathEdit
            // 
            this.pathEdit.Location = new System.Drawing.Point(93, 13);
            this.pathEdit.Name = "pathEdit";
            this.pathEdit.Size = new System.Drawing.Size(521, 20);
            this.pathEdit.TabIndex = 3;
            this.pathEdit.LocationChanged += new System.EventHandler(this.pathEdit_LocationChanged);
            this.pathEdit.TextChanged += new System.EventHandler(this.pathEdit_LocationChanged);
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(630, 11);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 4;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(52, 16);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(29, 13);
            this.pathLabel.TabIndex = 5;
            this.pathLabel.Text = "Path";
            // 
            // Table
            // 
            this.Table.AutoSize = true;
            this.Table.Location = new System.Drawing.Point(52, 42);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(34, 13);
            this.Table.TabIndex = 6;
            this.Table.Text = "Table";
            // 
            // FoxProFileReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.pathEdit);
            this.Controls.Add(this.tableView);
            this.Controls.Add(this.tableEdit);
            this.Name = "FoxProFileReaderForm";
            this.Text = "Fox Pro File Reader";
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tableEdit;
        private System.Windows.Forms.DataGridView tableView;
        private System.Windows.Forms.MaskedTextBox pathEdit;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Label Table;
        private System.Windows.Forms.FolderBrowserDialog browserDialog;
    }
}

