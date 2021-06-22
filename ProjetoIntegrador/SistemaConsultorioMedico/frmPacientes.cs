using System;
using System.IO;
using System.Windows.Forms;

namespace SistemaConsultorioMedico
{
    public partial class frmPacientes : Form
    {
        public frmPacientes()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarPaciente(txtNome.Text , txtTelefone.Text, txtDataNascimento.Text);
            LimparFormulario();
        }

        private void LimparFormulario()
        {
            txtNome.Clear();
            txtDataNascimento.Clear();
            txtTelefone.Clear();
            txtDiagnostico.Clear();
            txtConvenio.Clear();
        }

        private void SalvarPaciente(string nome , string telefone, string dataDeNascimento)
        {
            StreamWriter arquivo;
            string caminho = "C:\\sistema1\\pacientes.txt";
            arquivo = File.AppendText(caminho);
            arquivo.WriteLine(nome + " \t " + telefone + " - " + dataDeNascimento);
            arquivo.Close();
            MessageBox.Show("Paciente salvo!");
        }
    }
}
