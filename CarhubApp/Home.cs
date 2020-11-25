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
    public partial class Carhub : Form
    {
        Thread nt;

        public Carhub()
        {
            InitializeComponent();

            if(GlobalVariables.usernamelogin != null && GlobalVariables.usernamelogin != "") //Checando se o usuario esta logado
            {
                try
                {
                    //Checando se tem algum agendamento cadastrado no nome do usuario
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\iNayi\Desktop\carhub\CarhubApp\carhub.mdf;Integrated Security=True;Connect Timeout=30");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select count(cod_agenda) from agenda where usuario_ag=@login", con);
                    cmd.Parameters.AddWithValue("@login", GlobalVariables.usernamelogin);
                    int a = (int)cmd.ExecuteScalar();
                    con.Close();
                    if (a > 0)
                    {
                        l_agenda.Text = "Você tem visitas agendadas ativas!";
                    }
                    else
                    {
                        l_agenda.Text = "Aqui você pode ver seus compromissos marcados e marcar revisões e outros serviços.";
                    }

                    con.Open();
                    SqlCommand cmd2 = new SqlCommand("select count(cod_serv) from servicos_solicitados where usuario_ser=@login", con);
                    cmd2.Parameters.AddWithValue("@login", GlobalVariables.usernamelogin);
                    int s = (int)cmd2.ExecuteScalar();
                    con.Close();

                    if (s > 0)
                    {
                        l_servico.Text = "Você ter serviços ou visitas ativas!";
                    }
                    else
                    {
                        l_servico.Text = "Você ainda não efetuou nenhum serviço com a gente, marque um agora mesmo!";
                    }
                }
                catch (SqlException e)
                {
                    l_agenda.Text = "Aqui você pode ver seus compromissos marcados e marcar revisões e outros serviços.";
                    l_servico.Text = "Você ainda não efetuou nenhum serviço com a gente, marque um agora mesmo!";
                }
            }
            else
            {
                l_agenda.Text = "Logue para ver sua agenda.";
                l_servico.Text = "Logue para ver suas visitas e serviços!";
            }

            

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.usernamelogin != null && GlobalVariables.usernamelogin != "")
            {
                GlobalVariables.BackFromAgenda = 0;
                this.Close();
                nt = new Thread(agenda);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
            else
            {
                MessageBox.Show("Logue na sua conta primeiro ou cadastre-se.");
                this.Close();
                nt = new Thread(login);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
        }

        private void HeadHomeText_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ServicosBtn_Click(object sender, EventArgs e)
        {
            if(GlobalVariables.usernamelogin != null && GlobalVariables.usernamelogin != "")
            {
                this.Close();
                nt = new Thread(servico);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
            else
            {
                MessageBox.Show("Logue na sua conta primeiro ou cadastre-se.");
                this.Close();
                nt = new Thread(login);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
            
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(login);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        //Caminhos para cada form
        public void home()
        {
            Application.Run(new Carhub());
        }

        public void servico()
        {
            Application.Run(new Serviços());

        }

        public void agenda()
        {
            Application.Run(new Agenda());
        }
        public void login()
        {
            Application.Run(new Login());
        }
        public void agendavisua()
        {
            Application.Run(new ServiçosAgendadosVisualizar());
        }
        


        private void Carhub_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
