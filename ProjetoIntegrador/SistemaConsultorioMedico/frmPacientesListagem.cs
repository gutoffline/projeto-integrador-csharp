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
    public partial class frmPacientesListagem : Form
    {
        public frmPacientesListagem()
        {
            InitializeComponent();
        }

        private void btnNovoPaciente_Click(object sender, EventArgs e)
        {
            frmPacientes formulario = new frmPacientes();
            formulario.ShowDialog();
        }

        private void frmPacientesListagem_Load(object sender, EventArgs e)
        {
            Pesquisar("");
        }

        private void gridPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nomeBuscar = txtNomeBuscar.Text;
            Pesquisar(nomeBuscar);
        }

        private void txtNomeBuscar_TextChanged(object sender, EventArgs e)
        {
            string nomeBuscar = txtNomeBuscar.Text;
            Pesquisar(nomeBuscar);
        }

        private void Pesquisar(string nome)
        {
            string sqlBuscar = "";
            sqlBuscar = $"SELECT * FROM tb_pacientes WHERE nome LIKE '%{nome}%'";

            string bancoDeDados = "server=localhost;user id=root;password=;database=bd_consultorio;";

            MySqlConnection conexao = new MySqlConnection(bancoDeDados);
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(sqlBuscar, conexao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridPacientes.DataSource = dt;
                conexao.Close();
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Erro ao conectar. Erro: " + erro.Message);
            }
        }
    }
}
