﻿using System;
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
    public partial class Agenda : Form
    {
        Thread nt;
        Carhub ch = new Carhub();

        public Agenda()
        {
            InitializeComponent();
        }

        private void Agenda_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void PegarDataBtn_Click(object sender, EventArgs e)
        {
            if(monthCalendar1.SelectionRange.Start >= DateTime.Today)
            {
                //Estes dados precisam ir para o banco de dados:
                if (monthCalendar1.SelectionStart.DayOfWeek.ToString() == "Sunday")
                {
                    string message = "Desculpe, não abrimos aos domingos";
                    MessageBox.Show(message);
                }
                else
                {
                    if (InputVeiculo.Text != "" && AnoComboBox.Text != "")
                    {
                        if(Convert.ToInt32(AnoComboBox.Text) <= DateTime.Now.Year)
                        {
                            if (GlobalVariables.usernamelogin != null && GlobalVariables.usernamelogin != "")
                            {
                                try
                                {
                                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\iNayi\Desktop\carhub\CarhubApp\carhub.mdf;Integrated Security=True;Connect Timeout=30");
                                    con.Open();
                                    SqlCommand cmd = new SqlCommand("insert into agenda(data, veiculo, ano, usuario_ag) values (@data, @veiculo, @ano, @usuario_ag)", con);
                                    cmd.Parameters.AddWithValue("@data", monthCalendar1.SelectionStart.ToShortDateString());
                                    cmd.Parameters.AddWithValue("@veiculo", Convert.ToString(InputVeiculo.Text));
                                    cmd.Parameters.AddWithValue("@ano", Convert.ToString(AnoComboBox.Text));
                                    cmd.Parameters.AddWithValue("@usuario_ag", GlobalVariables.usernamelogin);
                                    cmd.ExecuteNonQuery();

                                    con.Close();

                                    MessageBox.Show("Sua visita foi agendada!");

                                    this.Close();
                                    if (GlobalVariables.BackFromAgenda == 0)
                                        nt = new Thread(ch.home);
                                    else nt = new Thread(ch.servico);
                                    nt.SetApartmentState(ApartmentState.STA);
                                    nt.Start();
                                }
                                catch (SqlException error)
                                {
                                    MessageBox.Show("Erro marcando visita.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Logue na sua conta primeiro.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Digite um ano válido. (<2020)");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro marcando visita.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Coloque uma data válida. (Que não tenha passado.)");
            }
            


            
        }

        private void InputVeiculo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            if (GlobalVariables.BackFromAgenda == 0)
                nt = new Thread(ch.home);
            else nt = new Thread(ch.servico);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void b_visuA_Click(object sender, EventArgs e)
        {
            Carhub ch = new Carhub();
            this.Close();
            nt = new Thread(ch.agendavisua);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void Agenda_Load_1(object sender, EventArgs e)
        {

        }
    }
}
