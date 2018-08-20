namespace ExemploCRUD.UI
{
    partial class frmCurso
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
            this.cmbCoordenador = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCoordenador = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.tbpConsulta = new System.Windows.Forms.TabPage();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
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
            this.tabControl1.Size = new System.Drawing.Size(321, 294);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tbpCadastro
            // 
            this.tbpCadastro.Controls.Add(this.cmbCoordenador);
            this.tbpCadastro.Controls.Add(this.btnCadastrar);
            this.tbpCadastro.Controls.Add(this.txtNome);
            this.tbpCadastro.Controls.Add(this.txtCodigo);
            this.tbpCadastro.Controls.Add(this.lblCoordenador);
            this.tbpCadastro.Controls.Add(this.lblNome);
            this.tbpCadastro.Controls.Add(this.lblCodigo);
            this.tbpCadastro.Location = new System.Drawing.Point(4, 22);
            this.tbpCadastro.Name = "tbpCadastro";
            this.tbpCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCadastro.Size = new System.Drawing.Size(313, 268);
            this.tbpCadastro.TabIndex = 0;
            this.tbpCadastro.Text = "Cadastro";
            this.tbpCadastro.UseVisualStyleBackColor = true;
            // 
            // cmbCoordenador
            // 
            this.cmbCoordenador.FormattingEnabled = true;
            this.cmbCoordenador.Location = new System.Drawing.Point(154, 118);
            this.cmbCoordenador.Name = "cmbCoordenador";
            this.cmbCoordenador.Size = new System.Drawing.Size(121, 21);
            this.cmbCoordenador.TabIndex = 7;
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
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(155, 71);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(120, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(155, 29);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(120, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // lblCoordenador
            // 
            this.lblCoordenador.AutoSize = true;
            this.lblCoordenador.Location = new System.Drawing.Point(29, 121);
            this.lblCoordenador.Name = "lblCoordenador";
            this.lblCoordenador.Size = new System.Drawing.Size(114, 13);
            this.lblCoordenador.TabIndex = 2;
            this.lblCoordenador.Text = "Nome do Coordenador";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(108, 78);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(108, 29);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo";
            // 
            // tbpConsulta
            // 
            this.tbpConsulta.Controls.Add(this.lblFiltro);
            this.tbpConsulta.Controls.Add(this.txtFiltro);
            this.tbpConsulta.Controls.Add(this.dgvResultado);
            this.tbpConsulta.Location = new System.Drawing.Point(4, 22);
            this.tbpConsulta.Name = "tbpConsulta";
            this.tbpConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tbpConsulta.Size = new System.Drawing.Size(313, 268);
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
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // dgvResultado
            // 
            this.dgvResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Location = new System.Drawing.Point(3, 45);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.Size = new System.Drawing.Size(307, 220);
            this.dgvResultado.TabIndex = 3;
            // 
            // frmCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 294);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmCurso";
            this.Text = "Curso";
            this.Load += new System.EventHandler(this.frmCurso_Load);
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
        private System.Windows.Forms.TabPage tbpConsulta;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCoordenador;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.ComboBox cmbCoordenador;
    }
}