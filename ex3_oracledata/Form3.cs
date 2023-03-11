using Microsoft.Reporting.Map.WebForms.BingMaps;
using Microsoft.Reporting.WinForms;
using System.Data;

namespace ex3_oracledata
{
    public partial class Form3 : Form
    {
        public Form3()
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
            var db = new omda();
            if (db.Connect(txtUid.Text, txtPwd.Text, txtServerName.Text, txtPort.Text, txtSid.Text))
            {
                var sql = "select 1 id, 'one' name from dual union select 2, 'two' from dual union select 3, 'three' from dual";

                return db.CreateDataTable(sql);
            }
            else
            {
                MessageBox.Show("Error connecting to the database");
                return null;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmdConnect_Click(object sender, EventArgs e)
        {
            var res = FindResourceName("Report3.rdlc");
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
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet3", data));

            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.RefreshReport();
        }
    }
}