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
    public partial class frmCurso : Form
    {
        public frmCurso()
        {
            InitializeComponent();
        }

        
        DAL.CoordenadorDAL coordenadorDAL = new DAL.CoordenadorDAL();

        BLL.Curso curso = new BLL.Curso();
        DAL.CursoDAL cursoDAL = new DAL.CursoDAL();


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            curso.Nome = txtNome.Text;

            //Recuperar o valor selecionado na combobox
            curso.Cod_coordenador = Convert.ToInt16(cmbCoordenador.SelectedValue);
            cursoDAL.Cadastrar(curso);
            MessageBox.Show("Curso cadastrado");

            txtNome.Clear();
            //Selecionar o primeiro item da combobox
            cmbCoordenador.SelectedIndex = 0;
        }

        private void frmCurso_Load(object sender, EventArgs e)
        {
            //Fonte de dados da cmbCoordenador
            cmbCoordenador.DataSource = coordenadorDAL.Consultar();

            //Configurar qual coluna sera utilizada para os valores
            cmbCoordenador.ValueMember = "Cod";

            //Configurar qual coluna sera utilizada para exibiçao
            cmbCoordenador.DisplayMember = "Nome";

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
            
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if(e.TabPageIndex == 1)
            {
                dgvResultado.DataSource = cursoDAL.Consultar();

                dgvResultado.Columns[2].Visible = false;
                dgvResultado.Columns[1].HeaderText = "Nome do Curso";
                dgvResultado.Columns[3].HeaderText = "Nome do Coordenador";
            }
        }
    }
}
