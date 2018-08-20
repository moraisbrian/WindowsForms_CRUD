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
    public partial class frmCoordenador : Form
    {
        public frmCoordenador()
        {
            InitializeComponent();
        }

        BLL.Coordenador coordenador = new BLL.Coordenador();
        DAL.CoordenadorDAL coordenadorDAL = new DAL.CoordenadorDAL();
        bool atualizar;

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
            coordenador.Nome = txtNome.Text;
            coordenador.Idade = int.Parse(txtIdade.Text);
            coordenador.Salario = double.Parse(txtSalario.Text);

            if (atualizar)
            {
                coordenadorDAL.Atualizar(coordenador);
                MessageBox.Show("Coordenador cadastrado!");
                btnCadastrar.Text = "Cadastrar";
                atualizar = false;
                txtCodigo.ReadOnly = false;
                btnCancelar.Visible = false;
            }

            else
            {
                coordenadorDAL.Cadastrar(coordenador);
                MessageBox.Show("Coordenador cadastrado!");
            }

            txtSalario.Clear();
            txtNome.Clear();
            txtIdade.Clear();
            txtCodigo.Clear();
            txtCodigo.Focus();


        }

        private void frmCoordenador_Load(object sender, EventArgs e)
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
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            coordenador.Nome = txtFiltro.Text;
            dgvResultado.DataSource = coordenadorDAL.Consultar(coordenador);
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 1) 
            {
                
                dgvResultado.DataSource = coordenadorDAL.Consultar();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta;

            if (dgvResultado.SelectedRows.Count > 0)
            {
                resposta = MessageBox.Show("Deseja realmente excluir?",
                                            "Confirmação",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question,
                                            MessageBoxDefaultButton.Button2);
                if (resposta == DialogResult.Yes)
                {
                    coordenador.Cod = Convert.ToInt16(dgvResultado.SelectedRows[0].Cells["Cod"].Value);
                    coordenadorDAL.Excluir(coordenador);
                    txtFiltro_TextChanged(null, null);
                }
            }
            else
            {
                MessageBox.Show("Selecione um registro");
            }
        }

        private void dgvResultado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            atualizar = true;
            txtCodigo.ReadOnly = true;
            btnCancelar.Visible = true;
            btnCadastrar.Text = "atualizar";

            coordenador.Cod = Convert.ToInt16(dgvResultado.SelectedRows[0].Cells["Cod"].Value.ToString());

            coordenador = coordenadorDAL.PreecheAluno(coordenador);

            txtCodigo.Text = coordenador.Cod.ToString();
            txtNome.Text = coordenador.Nome;
            txtIdade.Text = coordenador.Idade.ToString();
            txtSalario.Text = coordenador.Salario.ToString();

            tabControl1.SelectTab(0);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCadastrar.Text = "Cadastrar";
            atualizar = false;
            btnCancelar.Visible = false;
            txtCodigo.ReadOnly = false;

            txtCodigo.Clear();
            txtNome.Clear();
            txtIdade.Clear();
            txtSalario.Clear();

            txtCodigo.Focus();
        }
    }
}
