namespace rdlc_dotnet7
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(680, 15);
            label1.TabIndex = 0;
            label1.Text = "Step 1. Download and Install the RDLC Report Designer 2022 Extension, this is a VSIX file and will need to shutdown Visual Studio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 24);
            label2.Name = "label2";
            label2.Size = new Size(323, 15);
            label2.TabIndex = 1;
            label2.Text = "Step 2. Add the ReportViewerCore.Winforms Nuget package";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(reportViewer1);
            panel1.Location = new Point(12, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(1137, 417);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // reportViewer1
            // 
            reportViewer1.Dock = DockStyle.Fill;
            reportViewer1.Location = new Point(0, 0);
            reportViewer1.Name = "ReportViewer";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(1137, 417);
            reportViewer1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 39);
            label3.Name = "label3";
            label3.Size = new Size(1087, 15);
            label3.TabIndex = 3;
            label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 54);
            label4.Name = "label4";
            label4.Size = new Size(937, 15);
            label4.TabIndex = 4;
            label4.Text = "Step 4. Create a basic report, ensure that the Reports build action is set to Embedded Resource, then find the name of that embedded resource (there is code in Form1 to do that)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 69);
            label5.Name = "label5";
            label5.Size = new Size(935, 15);
            label5.TabIndex = 5;
            label5.Text = "Step 5. Then in the Form Load event set the ReportViewer Local Report to yhe embedded resource and RefreshReport(), you would lso want to set the DataSource on a real report";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1161, 521);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "RDLC Test in VS2022 using the buggy ReportViewer download (15.1.17)";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}