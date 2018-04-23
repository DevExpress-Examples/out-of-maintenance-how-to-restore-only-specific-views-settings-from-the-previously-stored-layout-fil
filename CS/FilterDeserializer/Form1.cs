using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FilterDeserializer {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        string layoutFileName = "test.xml";
        private void Form1_Load(object sender, EventArgs e) {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("ID", typeof(int));
            tbl.Columns.Add("Name", typeof(string));
            tbl.Columns.Add("Date", typeof(DateTime));
            tbl.Columns.Add("Payment", typeof(decimal));
            for(int i = 1; i < 30; i++)
                tbl.Rows.Add(i, string.Format("Item{0}", i % 7), DateTime.Now.AddDays(-60).AddDays(i), i * 3.3);
            gridControl1.DataSource = tbl;
        }

        private void btnSaveLayout_Click(object sender, EventArgs e) {
            gridView1.SaveLayoutToXml(layoutFileName, DevExpress.Utils.OptionsLayoutGrid.FullLayout);
        }

        private void btnRestoreLayout_Click(object sender, EventArgs e) {
            if(System.IO.File.Exists(layoutFileName))
                FilterDeserializer.LoadFilter(gridView1, layoutFileName);
        }
    }
}