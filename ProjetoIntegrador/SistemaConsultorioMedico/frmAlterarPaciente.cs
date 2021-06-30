using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SistemaConsultorioMedico
{
    public partial class frmAlterarPaciente : Form
    {
        public frmAlterarPaciente()
        {
            InitializeComponent();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            string idPaciente = txtID.Text;
            string bancoDeDados = "server=localhost;user id=root;password=;database=bd_consultorio;";
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);
            try
            {
                conexao.Open();
                string sqlBuscar = $"SELECT * FROM tb_pacientes WHERE id={idPaciente}";
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(sqlBuscar, conexao);
                da.Fill(dt);
                txtNome.Text = dt.Rows[0]["nome"].ToString();
                txtTelefone.Text = dt.Rows[0]["telefone"].ToString();
                txtDataDeNascimento.Text = dt.Rows[0]["data_nascimento"].ToString();
                txtConvenio.Text = dt.Rows[0]["convenio"].ToString();
                txtDiagnostico.Text = dt.Rows[0]["diagnostico"].ToString();
                conexao.Close();
            }
            catch(MySqlException erro)
            {
                MessageBox.Show("Algo errado com a conexão. Erro: " + erro.Message);
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string bancoDeDados = "server=localhost;user id=root; password=;database=bd_consultorio";
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);
            try
            {
                conexao.Open();
                string sqlAlterar = $"UPDATE tb_pacientes set nome='{txtNome.Text}' , data_nascimento='{txtDataDeNascimento.Text}' , telefone='{txtTelefone.Text}' , convenio='{txtConvenio.Text}' , diagnostico='{txtDiagnostico.Text}' WHERE id={txtID.Text}";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = sqlAlterar;
                cmd.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Alterado com sucesso");
            }catch(MySqlException erro)
            {
                MessageBox.Show("Algum erro ocorreu. Erro: " + erro.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string bancoDeDados = "server=localhost;user id=root;password=;database=bd_consultorio";
            string idPaciente = txtID.Text;
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);
            try
            {
                conexao.Open();
                string sqlExcluir = $"DELETE FROM tb_pacientes WHERE id={idPaciente}";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = sqlExcluir;
                cmd.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Paciente excluído com sucesso");
                txtNome.Clear();
                txtID.Clear();
            }
            catch(MySqlException erro)
            {
                MessageBox.Show("Erro de conexão. Erro: " + erro.Message);
            }
        }
    }
}
