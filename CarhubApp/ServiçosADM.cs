﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarhubApp
{
    public partial class ServiçosADM : Form
    {
        public ServiçosADM()
        {
            InitializeComponent();
        }

        private void ServiçosADM_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'carhubDataSet2.servicos_solicitados'. Você pode movê-la ou removê-la conforme necessário.
            this.servicos_solicitadosTableAdapter.Fill(this.carhubDataSet2.servicos_solicitados);

        }
    }
}
