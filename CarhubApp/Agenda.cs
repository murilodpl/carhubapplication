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

namespace CarhubApp
{
    public partial class Agenda : Form
    {
        Thread nt;
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
            //Estes dados precisam ir para o banco de dados:
            if (monthCalendar1.SelectionStart.DayOfWeek.ToString() == "Sunday")
            {
                string message = "Desculpe, não abrimos aos domingos";
                MessageBox.Show(message);
            }
            else
            {/*linka com o banco de dados*/
                monthCalendar1.SelectionStart.ToShortDateString();
                //InputVeiculo.Text;
                // AnoComboBox.SelectedValue.ToString();
                string message = "Sua vísita foi agendada!";
                MessageBox.Show(message);
                InputVeiculo.Clear();
                AnoComboBox.SelectedIndex = -1;
            }
        }

        private void InputVeiculo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Carhub ch = new Carhub();
            this.Close();
            if (GlobalVariables.BackFromAgenda == 0)
                nt = new Thread(ch.home);
            else nt = new Thread(ch.servico);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }
    }
}
