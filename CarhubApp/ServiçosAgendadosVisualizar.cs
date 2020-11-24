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
    public partial class ServiçosAgendadosVisualizar : Form
    {
        Thread nt;

        public ServiçosAgendadosVisualizar()
        {
            InitializeComponent();
        }

        private void ServiçosAgendadosVisualizar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'carhubDataSet1.agenda'. Você pode movê-la ou removê-la conforme necessário.
            this.agendaTableAdapter.Fill(this.carhubDataSet1.agenda);

        }

        private void b_voltar_Click(object sender, EventArgs e)
        {
            Carhub ch = new Carhub();
            this.Close();
            nt = new Thread(ch.agenda);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }
    }
}
