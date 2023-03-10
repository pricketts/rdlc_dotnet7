using Microsoft.Reporting.Map.WebForms.BingMaps;

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

        private void Form1_Load(object sender, EventArgs e)
        {
            var res = FindResourceName("Report1.rdlc");

            reportViewer1.LocalReport.ReportEmbeddedResource = res;
            reportViewer1.RefreshReport();
        }
    }
}