using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploCRUD.UI
{
    public partial class frmAluno : Form
    {
        public frmAluno()
        {
            InitializeComponent();
        }

        BLL.Aluno aluno = new BLL.Aluno();
        DAL.AlunoDAL alunoDAL = new DAL.AlunoDAL();
        bool atualizar;

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Preencher o objeto da BLL com o conteudo da UI.
            aluno.Ra = txtRa.Text;
            aluno.Nome = txtNome.Text;
            aluno.Cpf = txtCpf.Text;
            aluno.Idade = int.Parse(txtIdade.Text);

            if (atualizar)
            {
                alunoDAL.Atualizar(aluno);
                MessageBox.Show("Aluno cadastrado!");
                btnCadastrar.Text = "Cadastrar";
                atualizar = false;
                txtRa.ReadOnly = false;
                btnCancelar.Visible = false;
            }

            else
            {
                //Enviar para o Cadastrar da camada DAL
                alunoDAL.Cadastrar(aluno);
                MessageBox.Show("Aluno cadastrado!");

            }

            
            txtRa.Clear();
            txtNome.Clear();
            txtCpf.Clear();
            txtIdade.Clear();
            txtRa.Focus();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            //Verificar se a aba Consultar foi selecionada
            if(e.TabPageIndex == 1) // 0 --> Cadastrar || 1 --> Consultar
            {
                //Configurar a fonte de dados da DataGridView
                dgvResultado.DataSource = alunoDAL.Consultar();
            }
        }

        private void frmAluno_Load(object sender, EventArgs e)
        {
            //Configurar DataGridView
            //Evitar Edição
            dgvResultado.ReadOnly = true;
            //Evitar adicionar linhas (Cadastro direto na grid)
            dgvResultado.AllowUserToAddRows = false;
            //Evitar excluir linha
            dgvResultado.AllowUserToDeleteRows = false;
            //Evitar selecionar mais de uma linha
            dgvResultado.MultiSelect = false;
            //Ajustar colunas para ocupar o espaço disponivel
            dgvResultado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //Remover cabeçalho da linha (seta lateral)
            dgvResultado.RowHeadersVisible = false;
            //Evitar resize de linha
            dgvResultado.AllowUserToResizeRows = false;
            //Selecionar a linha inteira independente de qual selula clicar
            dgvResultado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            atualizar = false;
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            aluno.Nome = txtFiltro.Text;
            dgvResultado.DataSource = alunoDAL.Consultar(aluno);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta;

            if(dgvResultado.SelectedRows.Count > 0)
            {
                resposta = MessageBox.Show("Deseja realmente excluir?", 
                                            "Confirmação", 
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question,
                                            MessageBoxDefaultButton.Button2);
                if(resposta == DialogResult.Yes)
                {
                    aluno.Ra = dgvResultado.SelectedRows[0].Cells["RA"].Value.ToString();
                    alunoDAL.Excluir(aluno);
                    txtFiltro_TextChanged(null, null);
                }
            }
            else
            {
                MessageBox.Show("Selecione um registro");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCadastrar.Text = "Cadastrar"; 
            atualizar = false;
            btnCancelar.Visible = false;
            txtRa.ReadOnly = false;

            txtRa.Clear();
            txtNome.Clear();
            txtIdade.Clear();
            txtCpf.Clear();

            txtRa.Focus();
        }

        private void dgvResultado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            atualizar = true;
            txtRa.ReadOnly = true;
            btnCancelar.Visible = true;
            btnCadastrar.Text = "atualizar";

            aluno.Ra = dgvResultado.SelectedRows[0].Cells["RA"].Value.ToString();

            aluno = alunoDAL.PreecheAluno(aluno);

            txtRa.Text = aluno.Ra;
            txtNome.Text = aluno.Nome;
            txtIdade.Text = aluno.Idade.ToString();
            txtCpf.Text = aluno.Cpf;

            tabControl1.SelectTab(0); //Seleciona a aba Cadastrar

        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            frmAlunoRelatorio tela = new frmAlunoRelatorio();
            tela.ShowDialog();
            
        }
    }
}
