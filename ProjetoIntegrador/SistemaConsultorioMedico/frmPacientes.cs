using System;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(txtNome.Text, "Demo App - Message!");
                return;
            }
            else
            {
                SalvarPaciente(txtNome.Text, txtTelefone.Text, txtDataNascimento.Text, txtConvenio.Text, txtDiagnostico.Text);
                LimparFormulario();
            }
            
        }

        private void LimparFormulario()
        {
            txtNome.Clear();
            txtDataNascimento.Clear();
            txtTelefone.Clear();
            txtDiagnostico.Clear();
            txtConvenio.Clear();
        }

        private void SalvarPaciente(string nome , string telefone, string dataDeNascimento, string convenio , string diagnostico)
        {
            /* string de conexão */
            string bancoDeDados = "server=localhost;user id=root;password=;database=bd_consultorio";
            /* objeto de conexão */
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);

            /* tratamento de exceção */
            try
            {
                /* abertura da conexão */
                conexao.Open();

                // objeto que vai armazenar um comando sql e vai exercutar
                MySqlCommand cmd = new MySqlCommand();
                // informa o objeto de conexão para o cmd
                cmd.Connection = conexao; 
                // informar o sql que será executado
                cmd.CommandText = $"insert into tb_pacientes(nome, telefone, convenio, data_nascimento, diagnostico) values('{nome}' , '{telefone}' , '{convenio}' , '{dataDeNascimento}' , '{diagnostico}')";
                // executar o sql
                cmd.ExecuteNonQuery();

                //fechar a conexao
                conexao.Close();
                MessageBox.Show("Paciente cadastrado com sucesso!");
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Não foi possível conectar com o banco de dados: " + erro.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {
            

        }

        private void txtNome_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                e.Cancel = true;
                txtNome.Focus();
                errorProvider1.SetError(txtNome, "Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNome, "");
            }
        }
    }
}
