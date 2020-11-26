using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarhubApp
{
    public partial class ServiçosADM : Form
    {
        Thread nt;
        Carhub ch = new Carhub(); 
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\iNayi\Desktop\carhub\CarhubApp\carhub.mdf;Integrated Security=True;Connect Timeout=30");


        public ServiçosADM()
        {
            InitializeComponent(); 
            
            con.Open();
            SqlCommand cmd = new SqlCommand("select cod_serv, veiculo, desc_servico, preco, status, usuario_ser from servicos_solicitados", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void ServiçosADM_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'carhubDataSet3.servicos_solicitados'. Você pode movê-la ou removê-la conforme necessário.
            this.servicos_solicitadosTableAdapter1.Fill(this.carhubDataSet3.servicos_solicitados);

        }

        private void b_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(ch.servico);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void b_update_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Update servicos_solicitados set preco=@preco, status=@status where cod_serv=@cod_serv", con);
                cmd.Parameters.AddWithValue("@cod_serv", Convert.ToString(tb_cdServ.Text));
                cmd.Parameters.AddWithValue("@preco", Convert.ToString(tb_preco.Text));
                cmd.Parameters.AddWithValue("@status", Convert.ToString(tb_status.Text));
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Atualizado com Sucesso!!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro no atualização! " + Convert.ToString(ex));
            }
        }

        private void b_delete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete servicos_solicitados where cod_serv=@cod_serv", con);
                cmd.Parameters.AddWithValue("@cod_serv", Convert.ToString(tb_cdServ.Text));
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Deletado com Sucesso!!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao excluir! " + Convert.ToString(ex));
            }
        }

        private void b_searchCod_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select cod_serv, veiculo, desc_servico, preco, status, usuario_ser from servicos_solicitados where cod_serv=@cod_serv", con);
                cmd.Parameters.AddWithValue("@cod_serv", Convert.ToString(tb_cdServ.Text));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void b_searchCliente_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select cod_serv, veiculo, desc_servico, preco, status, usuario_ser from servicos_solicitados where usuario_ser=@cliente", con);
                cmd.Parameters.AddWithValue("@cliente", Convert.ToString(tb_cliente.Text));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void b_exibir_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select cod_serv, veiculo, desc_servico, preco, status, usuario_ser from servicos_solicitados", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void b_clear_Click(object sender, EventArgs e)
        {
            tb_cdServ.Clear();
            tb_cliente.Clear();
            tb_preco.Clear();
            tb_status.Clear();
        }
    }
}
