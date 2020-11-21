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
    public partial class CadastroOrçamentos : Form
    {
        Thread nt;

        public CadastroOrçamentos()
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
            CadastroServicos cds = new CadastroServicos(tb_desc_serv.Text);
            MessageBox.Show(cds.mensagem);
        }

        private void tb_desc_serv_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
