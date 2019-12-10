using DbfDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace FoxProReader
{
    public partial class FoxProFileReaderForm : Form
    {
        public FoxProFileReaderForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            if (browserDialog.ShowDialog() == DialogResult.OK) pathEdit.Text = browserDialog.SelectedPath;
        }

        private void pathEdit_LocationChanged(object sender, EventArgs e)
        {
            tableEdit.Items.Clear();
            string[] filePaths = Directory.GetFiles(pathEdit.Text, "*.DBF");
            foreach (string table in filePaths)
            {
                tableEdit.Items.Add(Path.GetFileName(table));
            }
        }

        private void tableEdit_TextChanged(object sender, EventArgs e)
        {
            var dbfPath = pathEdit.Text + '/' + tableEdit.Text;
            DataTable dt = new DataTable();
            using (var dbfTable = new DbfTable(dbfPath, Encoding.UTF8))
            {
                var header = dbfTable.Header;

                var versionDescription = header.VersionDescription;
                var hasMemo = dbfTable.Memo != null;
                var recordCount = header.RecordCount;

                foreach (var dbfColumn in dbfTable.Columns)
                {
                    dt.Columns.Add(new DataColumn(dbfColumn.Name));
                }
                int rowIndex = 0;
                while (rowIndex < recordCount){
                    DbfRecord record = dbfTable.ReadRecord();
                    if (record != null)
                    {
                        DataRow row = dt.NewRow();
                        int columIndex = 0;
                        foreach (var dbfColumn in dbfTable.Columns)
                        {
                            row[columIndex] = record.Values[columIndex];
                            ++columIndex;

                        }
                        dt.Rows.Add(row);
                    }
                    ++rowIndex;
                }
            }
            tableView.DataSource = dt;
        }
    }
}
