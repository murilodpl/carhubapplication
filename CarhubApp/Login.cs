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
    public partial class Login : Form
    {
        Thread nt;
        Carhub ch = new Carhub();

        public bool adm = false;

        public Login()
        {
            InitializeComponent();
            tb_senha.PasswordChar = '*';
        }

        private void b_login_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\iNayi\Desktop\carhub\CarhubApp\carhub.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("select count(login) from usuario where login=@login AND senha=@senha", con);
                cmd.Parameters.AddWithValue("@login", Convert.ToString(tb_usuario.Text));
                cmd.Parameters.AddWithValue("@senha", Convert.ToString(tb_senha.Text));
                int v = (int)cmd.ExecuteScalar();
                con.Close(); 
                
                con.Open();
                SqlCommand login = new SqlCommand("select login from usuario where login=@login AND senha=@senha", con);
                login.Parameters.AddWithValue("@login", Convert.ToString(tb_usuario.Text));
                login.Parameters.AddWithValue("@senha", Convert.ToString(tb_senha.Text));
                GlobalVariables.usernamelogin = Convert.ToString(login.ExecuteScalar());
                con.Close();

                if (v > 0)
                {
                    MessageBox.Show("Logado!");

                    con.Open();
                    SqlCommand logx = new SqlCommand("select adm from usuario where login=@login AND senha=@senha", con);
                    logx.Parameters.AddWithValue("@login", Convert.ToString(tb_usuario.Text));
                    logx.Parameters.AddWithValue("@senha", Convert.ToString(tb_senha.Text));
                    int l = (int)logx.ExecuteScalar();
                    con.Close();

                    if (l == 0)
                    {
                        adm = true;
                    }
                    else
                    {
                        adm = false;
                    }
                    this.Close();
                    nt = new Thread(ch.home);
                    nt.SetApartmentState(ApartmentState.STA);
                    nt.Start();
                }
                else
                {
                    MessageBox.Show("Login inválido!");
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show("" + error);
            }

        }

        private void b_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(ch.home);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void b_cadastrar_Click(object sender, EventArgs e)
        {
            if(tb_usuario.Text != "" && tb_senha.Text != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\iNayi\Desktop\carhub\CarhubApp\carhub.mdf;Integrated Security=True;Connect Timeout=30");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into usuario(login, senha, adm) values (@login, @senha, 1)", con);
                    cmd.Parameters.AddWithValue("@login", Convert.ToString(tb_usuario.Text));
                    cmd.Parameters.AddWithValue("@senha", Convert.ToString(tb_senha.Text));
                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("Cadastrado com Sucesso!!");
                }
                catch (SqlException error)
                {
                    MessageBox.Show("Cadastro inválido.");
                }
            }
            else
            {
                MessageBox.Show("Cadastro inválido.");
            }
            
        }
    }
}
