namespace ExemploCRUD.UI
{
    partial class frmAluno
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtRa = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblRa = new System.Windows.Forms.Label();
            this.tbpConsulta = new System.Windows.Forms.TabPage();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
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
            this.tabControl1.Size = new System.Drawing.Size(367, 325);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tbpCadastro
            // 
            this.tbpCadastro.Controls.Add(this.btnCancelar);
            this.tbpCadastro.Controls.Add(this.btnCadastrar);
            this.tbpCadastro.Controls.Add(this.txtCpf);
            this.tbpCadastro.Controls.Add(this.txtIdade);
            this.tbpCadastro.Controls.Add(this.txtNome);
            this.tbpCadastro.Controls.Add(this.txtRa);
            this.tbpCadastro.Controls.Add(this.lblCpf);
            this.tbpCadastro.Controls.Add(this.lblIdade);
            this.tbpCadastro.Controls.Add(this.lblNome);
            this.tbpCadastro.Controls.Add(this.lblRa);
            this.tbpCadastro.Location = new System.Drawing.Point(4, 22);
            this.tbpCadastro.Name = "tbpCadastro";
            this.tbpCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCadastro.Size = new System.Drawing.Size(359, 299);
            this.tbpCadastro.TabIndex = 0;
            this.tbpCadastro.Text = "Cadastro";
            this.tbpCadastro.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(187, 214);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(56, 214);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(92, 23);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Salvar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(153, 120);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(100, 20);
            this.txtCpf.TabIndex = 2;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(153, 169);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 20);
            this.txtIdade.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(152, 74);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtRa
            // 
            this.txtRa.Location = new System.Drawing.Point(153, 30);
            this.txtRa.Name = "txtRa";
            this.txtRa.Size = new System.Drawing.Size(100, 20);
            this.txtRa.TabIndex = 0;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(96, 127);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(27, 13);
            this.lblCpf.TabIndex = 3;
            this.lblCpf.Text = "CPF";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(89, 172);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(34, 13);
            this.lblIdade.TabIndex = 2;
            this.lblIdade.Text = "Idade";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(88, 81);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblRa
            // 
            this.lblRa.AutoSize = true;
            this.lblRa.Location = new System.Drawing.Point(101, 37);
            this.lblRa.Name = "lblRa";
            this.lblRa.Size = new System.Drawing.Size(22, 13);
            this.lblRa.TabIndex = 0;
            this.lblRa.Text = "RA";
            // 
            // tbpConsulta
            // 
            this.tbpConsulta.Controls.Add(this.btnRelatorio);
            this.tbpConsulta.Controls.Add(this.btnExcluir);
            this.tbpConsulta.Controls.Add(this.lblFiltro);
            this.tbpConsulta.Controls.Add(this.txtFiltro);
            this.tbpConsulta.Controls.Add(this.dgvResultado);
            this.tbpConsulta.Location = new System.Drawing.Point(4, 22);
            this.tbpConsulta.Name = "tbpConsulta";
            this.tbpConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tbpConsulta.Size = new System.Drawing.Size(359, 299);
            this.tbpConsulta.TabIndex = 1;
            this.tbpConsulta.Text = "Consulta";
            this.tbpConsulta.UseVisualStyleBackColor = true;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Location = new System.Drawing.Point(279, 13);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(72, 30);
            this.btnRelatorio.TabIndex = 8;
            this.btnRelatorio.Text = "Relatorio";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(191, 13);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(72, 29);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblFiltro
            // 
            this.lblFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(8, 13);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(81, 13);
            this.lblFiltro.TabIndex = 2;
            this.lblFiltro.Text = "Filtrar por Nome";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltro.Location = new System.Drawing.Point(11, 32);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(174, 20);
            this.txtFiltro.TabIndex = 1;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // dgvResultado
            // 
            this.dgvResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResultado.Location = new System.Drawing.Point(3, 58);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.Size = new System.Drawing.Size(356, 242);
            this.dgvResultado.TabIndex = 0;
            this.dgvResultado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultado_CellDoubleClick);
            // 
            // frmAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 325);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmAluno";
            this.Text = "Aluno";
            this.Load += new System.EventHandler(this.frmAluno_Load);
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
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtRa;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblRa;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRelatorio;
    }
}