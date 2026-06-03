using CosumoForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobsCRUD
{
    public partial class CrudForm : Form
    {
        public CrudForm()
        {
            InitializeComponent();
        }

        private void btnObterTodes_Click(object sender, EventArgs e)
        {
            FormObterTodes form = new FormObterTodes();
            form.ShowDialog();
        }

        private void btnCadastrarJob_Click(object sender, EventArgs e)
        {
            CadastroJob form = new CadastroJob();
            form.ShowDialog();
        }

        private void btnAtualizarCRUD_Click(object sender, EventArgs e)
        {
            AtualizarTodes form = new AtualizarTodes();
            form.ShowDialog();
        }
    }
}

