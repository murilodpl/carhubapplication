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

        }

    

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(home);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();

        }

        private void home()
        {
            Application.Run(new Carhub());
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }
    }
}
