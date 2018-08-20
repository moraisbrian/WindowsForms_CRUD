using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploCRUD
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanciando um objeto da tela frmAluno
            UI.frmAluno tela = new UI.frmAluno();

            //Prender dentro deste formulario (frmMenu)
            tela.MdiParent = this;

            //Exibir a tela
            tela.Show();
        }

        private void coordenadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanciando um objeto da tela frmAluno
            UI.frmCoordenador tela = new UI.frmCoordenador();

            //Prender dentro deste formulario (frmMenu)
            tela.MdiParent = this;

            //Exibir a tela
            tela.Show();
        }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanciando um objeto da tela frmAluno
            UI.frmCurso tela = new UI.frmCurso();

            //Prender dentro deste formulario (frmMenu)
            tela.MdiParent = this;

            //Exibir a tela
            tela.Show();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resposta;

            resposta = MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resposta == DialogResult.No)
            {
                e.Cancel = true;
            }
            //else
            //{
            //    MessageBox.Show(e.CloseReason.ToString());
            //}
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            this.Text = Properties.Settings.Default.Titulo;
            this.BackColor = Properties.Settings.Default.CorDasTelas;
            
            lblUsuario.Text = "Nenhum usuario logado";
            alunoToolStripMenuItem.Enabled = false;
            coordenadorToolStripMenuItem.Enabled = false;
            cursoToolStripMenuItem.Enabled = false;
            matriculaToolStripMenuItem.Enabled = false;
            backupToolStripMenuItem.Enabled = false;

            loginLogoutToolStripMenuItem.Text = "Login";

            UI.frmLogin tela = new UI.frmLogin();
            tela.ShowDialog();

            if (tela.RetornaLogin().Autenticado)
            {
                lblUsuario.Text = "Usuário logado: " + tela.RetornaLogin().Usuario;
                alunoToolStripMenuItem.Enabled = true;
                coordenadorToolStripMenuItem.Enabled = true;
                cursoToolStripMenuItem.Enabled = true;
                matriculaToolStripMenuItem.Enabled = true;
                backupToolStripMenuItem.Enabled = true;

                loginLogoutToolStripMenuItem.Text = "Logout";
            }
            
         }

        private void loginLogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenu_Load(null, null);
        }

        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.frmConfiguracao tela = new UI.frmConfiguracao();
            tela.MdiParent = this;
            tela.Show();
        }

        private void matriculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            UI.frmMatricula tela = new UI.frmMatricula();
        
            tela.MdiParent = this;
           
            tela.Show();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.frmBackup tela = new UI.frmBackup();
            tela.MdiParent = this;
            tela.Show();
        }
    }
}
