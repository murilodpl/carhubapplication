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
    public partial class ServiçosAgendadosVisualizar : Form
    {
        Thread nt;

        public ServiçosAgendadosVisualizar()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\iNayi\Desktop\carhub\CarhubApp\carhub.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("select cod_agenda, data, veiculo, ano, usuario_ag from agenda where usuario_ag=@user", con);
            cmd.Parameters.AddWithValue("@user", GlobalVariables.usernamelogin);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DGV_Agenda.DataSource = dt;

            con.Close();
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
