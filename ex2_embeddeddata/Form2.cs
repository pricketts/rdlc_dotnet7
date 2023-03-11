using Microsoft.Reporting.Map.WebForms.BingMaps;
using Microsoft.Reporting.WinForms;
using System.Data;

namespace ex2_embeddeddata
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private string FindResourceName(string filename)
        {
            var assembly = System.Reflection.Assembly.GetEntryAssembly();
            var resourceNames = assembly.GetManifestResourceNames();

            foreach (var res in resourceNames)
            {
                System.Diagnostics.Debug.Write(res);
            }

            return resourceNames.FirstOrDefault(x => x.EndsWith(filename));
        }

        private DataTable GetData()
        {
            // return some sample data

            DataTable table = new DataTable();
            table.Columns.Add(new DataColumn("ID"));
            table.Columns.Add(new DataColumn("NAME"));

            DataRow row = table.NewRow();
            row["ID"] = 1;
            row["NAME"] = "One";
            table.Rows.Add(row);

            row = table.NewRow();
            row["ID"] = 2;
            row["NAME"] = "Two";
            table.Rows.Add(row);

            row = table.NewRow();
            row["ID"] = 3;
            row["NAME"] = "Three";
            table.Rows.Add(row);

            row = table.NewRow();
            row["ID"] = 4;
            row["NAME"] = "Four";
            table.Rows.Add(row);

            row = table.NewRow();
            row["ID"] = 5;
            row["NAME"] = "Five";
            table.Rows.Add(row);

            row = table.NewRow();
            row["ID"] = 6;
            row["NAME"] = "Six";
            table.Rows.Add(row);

            row = table.NewRow();
            row["ID"] = 7;
            row["NAME"] = "Seven";
            table.Rows.Add(row);

            row = table.NewRow();
            row["ID"] = 8;
            row["NAME"] = "Eight";
            table.Rows.Add(row);

            row = table.NewRow();
            row["ID"] = 9;
            row["NAME"] = "Nine";
            table.Rows.Add(row);

            row = table.NewRow();
            row["ID"] = 10;
            row["NAME"] = "Ten";
            table.Rows.Add(row);

            return table;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var res = FindResourceName("Report2.rdlc");
            var data = GetData();

            reportViewer1.LocalReport.ReportEmbeddedResource = res;

            // Note: LocalReport.DataSources is empty, but GetDataSourceNames returns the name of the design time DataSource
            // the DataSource that we add to the report at runtime needs to have the same name

            System.Diagnostics.Debug.WriteLine("Report DataSources:");
            foreach (var ds in reportViewer1.LocalReport.GetDataSourceNames())
            {
                System.Diagnostics.Debug.WriteLine(ds);
            }

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", data));

            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.RefreshReport();
        }
    }
}