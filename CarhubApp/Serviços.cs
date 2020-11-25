using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace CarhubApp
{
    public partial class Serviços : Form
    {
        Thread nt;
        
        public Serviços()
        {
            InitializeComponent();

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\iNayi\Desktop\carhub\CarhubApp\carhub.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("select veiculo, desc_servico, preco, status, veic_placa from servicos_solicitados where usuario_ser=@login", con);
            cmd.Parameters.AddWithValue("@login", GlobalVariables.usernamelogin);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();

            if (GlobalVariables.adm == 1) //ADM FALSE
            {
                b_adm.Hide(); //Faz o botão adm sumir
            }
            else
            {
                b_adm.Show(); //Faz o botão adm aparecer
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(cad_orc);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void cad_orc()
        {
            Application.Run(new SolicitarServico());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Carhub ch = new Carhub();
            this.Close();
            nt = new Thread(ch.home);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'carhubDataSet.servicos_solicitados'. Você pode movê-la ou removê-la conforme necessário.
            this.servicos_solicitadosTableAdapter.Fill(this.carhubDataSet.servicos_solicitados);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GlobalVariables.BackFromAgenda = 1;
            Carhub ch = new Carhub();
            this.Close();
            nt = new Thread(ch.agenda);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void b_att_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\iNayi\Desktop\carhub\CarhubApp\carhub.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("select veiculo, desc_servico, preco, status, veic_placa from servicos_solicitados", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void b_adm_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(adm_serv);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void adm_serv()
        {
            Application.Run(new ServiçosADM());
        }
    }
}
