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
    public partial class Serviços : Form
    {
        Thread nt;
        
        public Serviços()
        {
            InitializeComponent();
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
            // TODO: esta linha de código carrega dados na tabela 'carhub_servico.servicos_solicitados'. Você pode movê-la ou removê-la conforme necessário.
            this.servicos_solicitadosTableAdapter1.Fill(this.carhub_servico.servicos_solicitados);
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
    }
}
