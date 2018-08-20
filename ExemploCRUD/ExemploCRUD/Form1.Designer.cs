namespace ExemploCRUD
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coordenadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matriculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.janelasAbertasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginLogoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem,
            this.coordenadorToolStripMenuItem,
            this.cursoToolStripMenuItem,
            this.matriculaToolStripMenuItem,
            this.janelasAbertasToolStripMenuItem,
            this.loginLogoutToolStripMenuItem,
            this.configuraçõesToolStripMenuItem,
            this.backupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.janelasAbertasToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(812, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.alunoToolStripMenuItem.Text = "Aluno";
            this.alunoToolStripMenuItem.Click += new System.EventHandler(this.alunoToolStripMenuItem_Click);
            // 
            // coordenadorToolStripMenuItem
            // 
            this.coordenadorToolStripMenuItem.Name = "coordenadorToolStripMenuItem";
            this.coordenadorToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.coordenadorToolStripMenuItem.Text = "Coordenador";
            this.coordenadorToolStripMenuItem.Click += new System.EventHandler(this.coordenadorToolStripMenuItem_Click);
            // 
            // cursoToolStripMenuItem
            // 
            this.cursoToolStripMenuItem.Name = "cursoToolStripMenuItem";
            this.cursoToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.cursoToolStripMenuItem.Text = "Curso";
            this.cursoToolStripMenuItem.Click += new System.EventHandler(this.cursoToolStripMenuItem_Click);
            // 
            // matriculaToolStripMenuItem
            // 
            this.matriculaToolStripMenuItem.Name = "matriculaToolStripMenuItem";
            this.matriculaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.matriculaToolStripMenuItem.Text = "Matricula";
            this.matriculaToolStripMenuItem.Click += new System.EventHandler(this.matriculaToolStripMenuItem_Click);
            // 
            // janelasAbertasToolStripMenuItem
            // 
            this.janelasAbertasToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.janelasAbertasToolStripMenuItem.Name = "janelasAbertasToolStripMenuItem";
            this.janelasAbertasToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.janelasAbertasToolStripMenuItem.Text = "Janelas Abertas";
            // 
            // loginLogoutToolStripMenuItem
            // 
            this.loginLogoutToolStripMenuItem.Name = "loginLogoutToolStripMenuItem";
            this.loginLogoutToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.loginLogoutToolStripMenuItem.Text = "Login/Logout";
            this.loginLogoutToolStripMenuItem.Click += new System.EventHandler(this.loginLogoutToolStripMenuItem_Click);
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            this.configuraçõesToolStripMenuItem.Click += new System.EventHandler(this.configuraçõesToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 482);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(812, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(140, 17);
            this.lblUsuario.Text = "Nenhum Usuario Logado";
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.backupToolStripMenuItem.Text = "Backup";
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 504);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coordenadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matriculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem janelasAbertasToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.ToolStripMenuItem loginLogoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
    }
}

