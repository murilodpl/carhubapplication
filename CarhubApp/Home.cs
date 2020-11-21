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
    public partial class Carhub : Form
    {
        Thread nt;

        public Carhub()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

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

        private void ProgressoBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(progresso);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void ServicosBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(servico);
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
        public void progresso()
        {
            Application.Run(new Progresso());
        }

        private void Carhub_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
