using Microsoft.Reporting.Map.WebForms.BingMaps;
using Microsoft.Reporting.WinForms;
using System.Data;

namespace rdlc_dotnet7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private string FindResourceName(string endswith)
        {
            var assembly = System.Reflection.Assembly.GetEntryAssembly();
            var resourceNames = assembly.GetManifestResourceNames();

            foreach (var res in resourceNames)
            {
                System.Diagnostics.Debug.Write(res);
            }

            return resourceNames.FirstOrDefault(x => x.EndsWith("Report1.rdlc"));
        }

        private DataTable GetData()
        {
            var db = new omda();
            var conn = db.Connect("phil", "cabbage99", "localhost", "1521", "xe");
            return db.CreateDataTable("select * from zzz order by tname");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var res = FindResourceName("Report0.rdlc");
            DataSet1 data = new DataSet1();

            reportViewer1.LocalReport.ReportEmbeddedResource = res;

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", GetData()));

            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.RefreshReport();
        }
    }
}