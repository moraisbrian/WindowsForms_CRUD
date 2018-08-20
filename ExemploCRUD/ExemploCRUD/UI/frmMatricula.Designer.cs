namespace ExemploCRUD.UI
{
    partial class frmMatricula
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpCadastro = new System.Windows.Forms.TabPage();
            this.cmbRa = new System.Windows.Forms.ComboBox();
            this.cmbCodCurso = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.lblRa = new System.Windows.Forms.Label();
            this.lblCodigoCurso = new System.Windows.Forms.Label();
            this.tbpConsulta = new System.Windows.Forms.TabPage();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.txtDataMatricula = new System.Windows.Forms.MaskedTextBox();
            this.tabControl1.SuspendLayout();
            this.tbpCadastro.SuspendLayout();
            this.tbpConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpCadastro);
            this.tabControl1.Controls.Add(this.tbpConsulta);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(343, 264);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tbpCadastro
            // 
            this.tbpCadastro.Controls.Add(this.txtDataMatricula);
            this.tbpCadastro.Controls.Add(this.cmbRa);
            this.tbpCadastro.Controls.Add(this.cmbCodCurso);
            this.tbpCadastro.Controls.Add(this.btnCadastrar);
            this.tbpCadastro.Controls.Add(this.lblData);
            this.tbpCadastro.Controls.Add(this.lblRa);
            this.tbpCadastro.Controls.Add(this.lblCodigoCurso);
            this.tbpCadastro.Location = new System.Drawing.Point(4, 22);
            this.tbpCadastro.Name = "tbpCadastro";
            this.tbpCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCadastro.Size = new System.Drawing.Size(335, 238);
            this.tbpCadastro.TabIndex = 0;
            this.tbpCadastro.Text = "Cadastro";
            this.tbpCadastro.UseVisualStyleBackColor = true;
            // 
            // cmbRa
            // 
            this.cmbRa.FormattingEnabled = true;
            this.cmbRa.Location = new System.Drawing.Point(155, 75);
            this.cmbRa.Name = "cmbRa";
            this.cmbRa.Size = new System.Drawing.Size(121, 21);
            this.cmbRa.TabIndex = 8;
            // 
            // cmbCodCurso
            // 
            this.cmbCodCurso.FormattingEnabled = true;
            this.cmbCodCurso.Location = new System.Drawing.Point(155, 29);
            this.cmbCodCurso.Name = "cmbCodCurso";
            this.cmbCodCurso.Size = new System.Drawing.Size(121, 21);
            this.cmbCodCurso.TabIndex = 7;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(32, 184);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(243, 23);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(56, 121);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(91, 13);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "Data da Matricula";
            // 
            // lblRa
            // 
            this.lblRa.AutoSize = true;
            this.lblRa.Location = new System.Drawing.Point(82, 78);
            this.lblRa.Name = "lblRa";
            this.lblRa.Size = new System.Drawing.Size(67, 13);
            this.lblRa.TabIndex = 1;
            this.lblRa.Text = "RA do Aluno";
            // 
            // lblCodigoCurso
            // 
            this.lblCodigoCurso.AutoSize = true;
            this.lblCodigoCurso.Location = new System.Drawing.Point(30, 29);
            this.lblCodigoCurso.Name = "lblCodigoCurso";
            this.lblCodigoCurso.Size = new System.Drawing.Size(119, 13);
            this.lblCodigoCurso.TabIndex = 0;
            this.lblCodigoCurso.Text = "Codigo do Coordenador";
            // 
            // tbpConsulta
            // 
            this.tbpConsulta.Controls.Add(this.lblFiltro);
            this.tbpConsulta.Controls.Add(this.txtFiltro);
            this.tbpConsulta.Controls.Add(this.dgvResultado);
            this.tbpConsulta.Location = new System.Drawing.Point(4, 22);
            this.tbpConsulta.Name = "tbpConsulta";
            this.tbpConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tbpConsulta.Size = new System.Drawing.Size(335, 238);
            this.tbpConsulta.TabIndex = 1;
            this.tbpConsulta.Text = "Consulta";
            this.tbpConsulta.UseVisualStyleBackColor = true;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(6, 3);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(81, 13);
            this.lblFiltro.TabIndex = 5;
            this.lblFiltro.Text = "Filtrar por Nome";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(3, 19);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(117, 20);
            this.txtFiltro.TabIndex = 4;
            // 
            // dgvResultado
            // 
            this.dgvResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Location = new System.Drawing.Point(3, 45);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.Size = new System.Drawing.Size(329, 190);
            this.dgvResultado.TabIndex = 3;
            // 
            // txtDataMatricula
            // 
            this.txtDataMatricula.Location = new System.Drawing.Point(155, 118);
            this.txtDataMatricula.Mask = "00/00/0000";
            this.txtDataMatricula.Name = "txtDataMatricula";
            this.txtDataMatricula.Size = new System.Drawing.Size(120, 20);
            this.txtDataMatricula.TabIndex = 9;
            this.txtDataMatricula.ValidatingType = typeof(System.DateTime);
            // 
            // frmMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 264);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMatricula";
            this.Text = "Matricula";
            this.Load += new System.EventHandler(this.frmMatricula_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbpCadastro.ResumeLayout(false);
            this.tbpCadastro.PerformLayout();
            this.tbpConsulta.ResumeLayout(false);
            this.tbpConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpCadastro;
        private System.Windows.Forms.ComboBox cmbCodCurso;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblRa;
        private System.Windows.Forms.Label lblCodigoCurso;
        private System.Windows.Forms.TabPage tbpConsulta;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.ComboBox cmbRa;
        private System.Windows.Forms.MaskedTextBox txtDataMatricula;
    }
}