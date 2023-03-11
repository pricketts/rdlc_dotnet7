namespace ex3_oracledata
{
    partial class Form3
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label1 = new Label();
            panel1 = new Panel();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            txtUid = new ToolStripTextBox();
            toolStripLabel2 = new ToolStripLabel();
            txtPwd = new ToolStripTextBox();
            toolStripLabel3 = new ToolStripLabel();
            txtServerName = new ToolStripTextBox();
            toolStripLabel4 = new ToolStripLabel();
            txtPort = new ToolStripTextBox();
            toolStripLabel5 = new ToolStripLabel();
            txtSid = new ToolStripTextBox();
            cmdConnect = new ToolStripButton();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(621, 15);
            label1.TabIndex = 0;
            label1.Text = "See: ex1 for a list of what needs to be installed and the workarounds to get the reportviewer to display in the designer";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(reportViewer1);
            panel1.Location = new Point(12, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(1137, 394);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // reportViewer1
            // 
            reportViewer1.Dock = DockStyle.Fill;
            reportViewer1.Location = new Point(0, 0);
            reportViewer1.Name = "ReportViewer";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(1137, 394);
            reportViewer1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(356, 15);
            label2.TabIndex = 3;
            label2.Text = "See: ex2 for details of adding a DataSet and binding it to the report";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 65);
            label3.Name = "label3";
            label3.Size = new Size(378, 15);
            label3.TabIndex = 4;
            label3.Text = "Step 1. Add the Oracle.ManagedDataAccess.Core package from NuGet";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 80);
            label4.Name = "label4";
            label4.Size = new Size(1047, 15);
            label4.TabIndex = 5;
            label4.Text = "Step 2. In the Form Load event connect to your Oracle database and write a sql select statement to return some sample data in the format that the report is expecting and then bind that to the Report";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, txtUid, toolStripLabel2, txtPwd, toolStripLabel3, txtServerName, toolStripLabel4, txtPort, toolStripLabel5, txtSid, cmdConnect });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1161, 25);
            toolStrip1.TabIndex = 7;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(103, 22);
            toolStripLabel1.Text = "Oracle: Username:";
            // 
            // txtUid
            // 
            txtUid.Name = "txtUid";
            txtUid.Size = new Size(100, 25);
            txtUid.Text = "user";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(60, 22);
            toolStripLabel2.Text = "Password:";
            // 
            // txtPwd
            // 
            txtPwd.Name = "txtPwd";
            txtPwd.Size = new Size(100, 25);
            txtPwd.Text = "pwd";
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(77, 22);
            toolStripLabel3.Text = "Server Name:";
            // 
            // txtServerName
            // 
            txtServerName.Name = "txtServerName";
            txtServerName.Size = new Size(100, 25);
            txtServerName.Text = "localhost";
            // 
            // toolStripLabel4
            // 
            toolStripLabel4.Name = "toolStripLabel4";
            toolStripLabel4.Size = new Size(83, 22);
            toolStripLabel4.Text = "Database Port:";
            // 
            // txtPort
            // 
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(100, 25);
            txtPort.Text = "1521";
            // 
            // toolStripLabel5
            // 
            toolStripLabel5.Name = "toolStripLabel5";
            toolStripLabel5.Size = new Size(89, 22);
            toolStripLabel5.Text = "Instance Name:";
            // 
            // txtSid
            // 
            txtSid.Name = "txtSid";
            txtSid.Size = new Size(100, 25);
            txtSid.Text = "XE";
            // 
            // cmdConnect
            // 
            cmdConnect.DisplayStyle = ToolStripItemDisplayStyle.Text;
            cmdConnect.Image = (Image)resources.GetObject("cmdConnect.Image");
            cmdConnect.ImageTransparentColor = Color.Magenta;
            cmdConnect.Name = "cmdConnect";
            cmdConnect.Size = new Size(56, 22);
            cmdConnect.Text = "Connect";
            cmdConnect.Click += cmdConnect_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1161, 521);
            Controls.Add(toolStrip1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "RDLC Test in VS2022 using the buggy ReportViewer download (15.1.17)";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox txtUid;
        private ToolStripLabel toolStripLabel2;
        private ToolStripTextBox txtPwd;
        private ToolStripLabel toolStripLabel3;
        private ToolStripTextBox txtServerName;
        private ToolStripLabel toolStripLabel4;
        private ToolStripTextBox txtPort;
        private ToolStripLabel toolStripLabel5;
        private ToolStripTextBox txtSid;
        private ToolStripButton cmdConnect;
    }
}