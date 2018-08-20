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
    public partial class frmAlunoRelatorio : Form
    {
        public frmAlunoRelatorio()
        {
            InitializeComponent();
        }

        private void frmAlunoRelatorio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsCRUD.TB_ALUNO' table. You can move, or remove it, as needed.
            this.TB_ALUNOTableAdapter.Fill(this.dsCRUD.TB_ALUNO);

            this.reportViewer1.RefreshReport();
        }
    }
}
