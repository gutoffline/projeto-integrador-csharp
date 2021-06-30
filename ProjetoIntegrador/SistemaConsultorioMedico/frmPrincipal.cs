using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaConsultorioMedico
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void listagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPacientesListagem formulario = new frmPacientesListagem();
            formulario.ShowDialog();
        }

        private void novoPacitenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPacientes formulario = new frmPacientes();
            formulario.ShowDialog();
        }

        private void alterarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlterarPaciente formulario = new frmAlterarPaciente();
            formulario.ShowDialog();
        }
    }
}
