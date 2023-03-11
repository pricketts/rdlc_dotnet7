namespace ex2_embeddeddata
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
            label1 = new Label();
            panel1 = new Panel();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(621, 15);
            label1.TabIndex = 0;
            label1.Text = "See: ex1 for a list of what needs to be installed and the workarounds to get the reportviewer to display in the designer";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(reportViewer1);
            panel1.Location = new Point(12, 122);
            panel1.Name = "panel1";
            panel1.Size = new Size(1137, 387);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // reportViewer1
            // 
            reportViewer1.Dock = DockStyle.Fill;
            reportViewer1.Location = new Point(0, 0);
            reportViewer1.Name = "ReportViewer";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(1137, 387);
            reportViewer1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 24);
            label2.Name = "label2";
            label2.Size = new Size(297, 15);
            label2.TabIndex = 3;
            label2.Text = "Step 1. Create DataSet1 with the columns ID and NAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 39);
            label3.Name = "label3";
            label3.Size = new Size(583, 15);
            label3.TabIndex = 4;
            label3.Text = "Step 2. Add a Table to the body of the report, link the table to DataSet1 and map the columns to ID and NAME";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 54);
            label4.Name = "label4";
            label4.Size = new Size(953, 15);
            label4.TabIndex = 5;
            label4.Text = "Step 3. In the Form load event create a DataTable with the columns ID and NAME then populate it with a few rows of data, and bind this DataTable into the DataSources of the report";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1161, 521);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
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
        private Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}