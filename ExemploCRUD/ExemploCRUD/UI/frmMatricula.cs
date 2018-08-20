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
    public partial class frmMatricula : Form
    {
        public frmMatricula()
        {
            InitializeComponent();
        }

        DAL.AlunoDAL alunoDAL = new DAL.AlunoDAL();
        BLL.Matricula matricula = new BLL.Matricula();
        DAL.MatriculaDAL matriculaDAL = new DAL.MatriculaDAL();
        DAL.CursoDAL cursoDAL = new DAL.CursoDAL();
        BLL.Curso curso = new BLL.Curso();

        private void frmMatricula_Load(object sender, EventArgs e)
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

            //Fonte de dados da cmbCoordenador
            cmbRa.DataSource = alunoDAL.Consultar();
            cmbCodCurso.DataSource = cursoDAL.Consultar();

            //Configurar qual coluna sera utilizada para os valores
            cmbCodCurso.ValueMember = "Cod";
            cmbRa.ValueMember = "RA";

            //Configurar qual coluna sera utilizada para exibiçao
            cmbCodCurso.DisplayMember = "Cod";
            cmbRa.DisplayMember = "RA";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            matricula.Data_matricula = Convert.ToDateTime(txtDataMatricula.Text);


            //Recuperar o valor selecionado na combobox
            matricula.Cod_curso = Convert.ToInt32(cmbCodCurso.SelectedValue);           
            matricula.Ra_aluno = Convert.ToInt32(cmbRa.SelectedValue);
            matriculaDAL.Cadastrar(matricula);
            MessageBox.Show("Matricula concluida");

            txtDataMatricula.Clear();
            
            //Selecionar o primeiro item da combobox
            cmbCodCurso.SelectedIndex = 0;
            cmbRa.SelectedIndex = 0;
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            dgvResultado.DataSource = matriculaDAL.Consultar();

            dgvResultado.Columns[0].HeaderText = "Codigo do Coordenador";
            dgvResultado.Columns[1].HeaderText = "RA do Aluno";
            dgvResultado.Columns[2].HeaderText = "Data da Matricula";
        }
    }
}
