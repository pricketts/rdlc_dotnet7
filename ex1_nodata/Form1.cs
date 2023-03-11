using Microsoft.Reporting.WinForms;

namespace ex1_nodata
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

        private string FindResourceName(string filename)
        {
            // I have found that this is a reliable way of getting the named resource,
            // otherwise the full path would have to be hard coded,
            // this way just the filename has to be hard coded

            var assembly = System.Reflection.Assembly.GetEntryAssembly();
            var resourceNames = assembly.GetManifestResourceNames();

            foreach (var res in resourceNames)
            {
                System.Diagnostics.Debug.Write(res);
            }

            return resourceNames.FirstOrDefault(x => x.EndsWith(filename));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var res = FindResourceName("Report1.rdlc");

            reportViewer1.LocalReport.ReportEmbeddedResource = res;

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.RefreshReport();
        }
    }
}