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
using System.Data.SqlClient;

namespace CarhubApp
{
    public partial class SolicitarServico : Form
    {
        Thread nt;
        Carhub ch = new Carhub();

        public SolicitarServico()
        {
            InitializeComponent();
        }

        private void CadastroOrçamentos_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void b_cad_serv_Click(object sender, EventArgs e)
        {
            if (tb_desc_serv.Text != "" && tb_veic.Text != "" && cb_ano.Text != "") 
            {
                if (Convert.ToInt32(cb_ano.Text) <= 2020)
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\iNayi\Desktop\carhub\CarhubApp\carhub.mdf;Integrated Security=True;Connect Timeout=30");
                        con.Open();
                        SqlCommand cmd = new SqlCommand("insert into servicos_solicitados(veiculo, ano, desc_servico, usuario_ser) values (@veiculo,@ano,@desc_servico,@user)", con);
                        cmd.Parameters.AddWithValue("@veiculo", Convert.ToString(tb_veic.Text));
                        cmd.Parameters.AddWithValue("@ano", Convert.ToString(cb_ano.Text));
                        cmd.Parameters.AddWithValue("@desc_servico", Convert.ToString(tb_desc_serv.Text));
                        cmd.Parameters.AddWithValue("@user", GlobalVariables.usernamelogin);
                        cmd.ExecuteNonQuery();

                        con.Close();

                        MessageBox.Show("Cadastrado com Sucesso!!");

                        this.Close();
                        nt = new Thread(ch.servico);
                        nt.SetApartmentState(ApartmentState.STA);
                        nt.Start();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Erro no cadastro! " + Convert.ToString(ex));
                    }
                }
                else
                {
                    MessageBox.Show("Digite um ano válido. (<2020)");
                }
            }
            else
            {
                MessageBox.Show("Digite valores válidos!");
            }

            
        }

        private void tb_desc_serv_TextChanged(object sender, EventArgs e)
        {

        }

        private void b_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(ch.servico);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
