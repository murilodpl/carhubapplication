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
    public partial class SolicitarServico : Form
    {
        Thread nt;

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
            CadastroServicos cds = new CadastroServicos(Convert.ToString(tb_veic.Text), Convert.ToString(cb_ano.Text), Convert.ToString(tb_desc_serv.Text));
            
            MessageBox.Show(cds.mensagem);
        }

        private void tb_desc_serv_TextChanged(object sender, EventArgs e)
        {

        }

        private void b_voltar_Click(object sender, EventArgs e)
        {
            Carhub ch = new Carhub();
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
