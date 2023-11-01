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

namespace ImplementacaoBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarDadosBanco();

        }

        private void CarregarDadosBanco()
        {
            string conexao = "server=localhost;database=dbstudents2023;uid=root;pwd=etec";
            MySqlConnection conexaoMYSQL = new MySqlConnection(conexao);
            conexaoMYSQL.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from tbAlunos", conexaoMYSQL);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvAluno.DataSource = dt;

        }

        private void dgvAluno_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtIdAluno.Text = dgvAluno.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNmAluno.Text = dgvAluno.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCpfAluno.Text = dgvAluno.Rows[e.RowIndex].Cells[2].Value.ToString();
            pnIAlterar.Visible = true;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string conexao = "server=localhost;database=dbstudents2023;uid=root;pwd=etec";
            MySqlConnection conexaoMYSQL = new MySqlConnection(conexao);
            conexaoMYSQL.Open();
            MySqlCommand comando = new MySqlCommand("update tbAlunos set nmAluno='" + txtNmAluno.Text + "', cpfAluno='" + txtCpfAluno.Text + "' where idAluno=" + txtIdAluno.Text + ";", conexaoMYSQL);
            comando.ExecuteNonQuery();
            MessageBox.Show("Dados alterados com sucesso!");
            txtNmAluno.Text = "";
            txtCpfAluno.Text = "";
            txtIdAluno.Text = "";
            pnIAlterar.Visible = false;
            CarregarDadosBanco();

               
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult caixaMensagem = MessageBox.Show("Deseja realmente excluir esse aluno?", "Etec Taboão da Serra", MessageBoxButtons.YesNo);

            if (caixaMensagem == DialogResult.Yes)
            {
                string conexao = "server=localhost;database=dbstudents2023;uid=root;pwd=etec";
                MySqlConnection conexaoMYSQL = new MySqlConnection(conexao);
                conexaoMYSQL.Open();
                MySqlCommand comando = new MySqlCommand("delete from tbAlunos where idAluno=" + txtIdAluno.Text + ";", conexaoMYSQL);
                comando.ExecuteNonQuery();
                MessageBox.Show("Dado excluído com sucesso!");
                txtNmAluno.Text = "";
                txtCpfAluno.Text = "";
                pnIAlterar.Visible = false;
                CarregarDadosBanco();
            }
        }

        private void btnAddAluno_Click(object sender, EventArgs e)
        {
            if (txtNmAluno.Text == "" || txtCpfAluno.Text == "" || txtIdAluno.Text == "")
            {

                MessageBox.Show("Por favor complete todos os campos");

            }

            else
            {
                MySqlConnection mySql = new MySqlConnection("server=localhost;database=dbstudents2023;uid=root;pwd=etec");
                mySql.Open();
                MySqlCommand comando = new MySqlCommand("Insert into tbAlunos (IdAluno, NmAluno, CpfAluno) values ('" + txtIdAluno.Text + "','" + txtNmAluno + "','" + txtCpfAluno + "');", mySql);
                comando.ExecuteNonQuery();

                MessageBox.Show("Aluno registrado com sucesso!");
                txtNmAluno.Text = "";
                txtIdAluno.Text = "";
                txtCpfAluno.Text = "";
            }


        }
    }
}
