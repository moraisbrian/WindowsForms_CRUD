namespace ExemploCRUD.UI
{
    partial class frmAlunoRelatorio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsCRUD = new ExemploCRUD.UI.dsCRUD();
            this.TB_ALUNOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TB_ALUNOTableAdapter = new ExemploCRUD.UI.dsCRUDTableAdapters.TB_ALUNOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsCRUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_ALUNOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsAluno";
            reportDataSource1.Value = this.TB_ALUNOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ExemploCRUD.UI.rptAluno.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(677, 356);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsCRUD
            // 
            this.dsCRUD.DataSetName = "dsCRUD";
            this.dsCRUD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TB_ALUNOBindingSource
            // 
            this.TB_ALUNOBindingSource.DataMember = "TB_ALUNO";
            this.TB_ALUNOBindingSource.DataSource = this.dsCRUD;
            // 
            // TB_ALUNOTableAdapter
            // 
            this.TB_ALUNOTableAdapter.ClearBeforeFill = true;
            // 
            // frmAlunoRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 356);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmAlunoRelatorio";
            this.Text = "frmAlunoRelatorio";
            this.Load += new System.EventHandler(this.frmAlunoRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsCRUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_ALUNOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TB_ALUNOBindingSource;
        private dsCRUD dsCRUD;
        private dsCRUDTableAdapters.TB_ALUNOTableAdapter TB_ALUNOTableAdapter;
    }
}