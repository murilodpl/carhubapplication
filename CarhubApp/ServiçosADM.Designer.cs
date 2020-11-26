﻿
namespace CarhubApp
{
    partial class ServiçosADM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.servicossolicitadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carhubDataSet2 = new CarhubApp.carhubDataSet2();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_cdServ = new System.Windows.Forms.TextBox();
            this.b_update = new System.Windows.Forms.Button();
            this.b_voltar = new System.Windows.Forms.Button();
            this.b_delete = new System.Windows.Forms.Button();
            this.b_searchCod = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_preco = new System.Windows.Forms.TextBox();
            this.tb_status = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.servicos_solicitadosTableAdapter = new CarhubApp.carhubDataSet2TableAdapters.servicos_solicitadosTableAdapter();
            this.b_searchCliente = new System.Windows.Forms.Button();
            this.tb_cliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.b_exibir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.carhubDataSet3 = new CarhubApp.carhubDataSet3();
            this.servicossolicitadosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.servicos_solicitadosTableAdapter1 = new CarhubApp.carhubDataSet3TableAdapters.servicos_solicitadosTableAdapter();
            this.codservDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descservicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.servicossolicitadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carhubDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carhubDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicossolicitadosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // servicossolicitadosBindingSource
            // 
            this.servicossolicitadosBindingSource.DataMember = "servicos_solicitados";
            this.servicossolicitadosBindingSource.DataSource = this.carhubDataSet2;
            // 
            // carhubDataSet2
            // 
            this.carhubDataSet2.DataSetName = "carhubDataSet2";
            this.carhubDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código do Serviço:";
            // 
            // tb_cdServ
            // 
            this.tb_cdServ.Location = new System.Drawing.Point(153, 30);
            this.tb_cdServ.Name = "tb_cdServ";
            this.tb_cdServ.Size = new System.Drawing.Size(39, 20);
            this.tb_cdServ.TabIndex = 4;
            // 
            // b_update
            // 
            this.b_update.Location = new System.Drawing.Point(12, 326);
            this.b_update.Name = "b_update";
            this.b_update.Size = new System.Drawing.Size(75, 23);
            this.b_update.TabIndex = 5;
            this.b_update.Text = "Atualizar";
            this.b_update.UseVisualStyleBackColor = true;
            this.b_update.Click += new System.EventHandler(this.b_update_Click);
            // 
            // b_voltar
            // 
            this.b_voltar.Location = new System.Drawing.Point(697, 326);
            this.b_voltar.Name = "b_voltar";
            this.b_voltar.Size = new System.Drawing.Size(75, 23);
            this.b_voltar.TabIndex = 6;
            this.b_voltar.Text = "Voltar";
            this.b_voltar.UseVisualStyleBackColor = true;
            this.b_voltar.Click += new System.EventHandler(this.b_voltar_Click);
            // 
            // b_delete
            // 
            this.b_delete.Location = new System.Drawing.Point(103, 326);
            this.b_delete.Name = "b_delete";
            this.b_delete.Size = new System.Drawing.Size(75, 23);
            this.b_delete.TabIndex = 7;
            this.b_delete.Text = "Deletar";
            this.b_delete.UseVisualStyleBackColor = true;
            this.b_delete.Click += new System.EventHandler(this.b_delete_Click);
            // 
            // b_searchCod
            // 
            this.b_searchCod.Location = new System.Drawing.Point(297, 326);
            this.b_searchCod.Name = "b_searchCod";
            this.b_searchCod.Size = new System.Drawing.Size(133, 23);
            this.b_searchCod.TabIndex = 8;
            this.b_searchCod.Text = "Procurar (Por Código)";
            this.b_searchCod.UseVisualStyleBackColor = true;
            this.b_searchCod.Click += new System.EventHandler(this.b_searchCod_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(206, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Preço:";
            // 
            // tb_preco
            // 
            this.tb_preco.Location = new System.Drawing.Point(264, 30);
            this.tb_preco.Name = "tb_preco";
            this.tb_preco.Size = new System.Drawing.Size(173, 20);
            this.tb_preco.TabIndex = 11;
            // 
            // tb_status
            // 
            this.tb_status.Location = new System.Drawing.Point(513, 30);
            this.tb_status.Name = "tb_status";
            this.tb_status.Size = new System.Drawing.Size(83, 20);
            this.tb_status.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(453, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Status:";
            // 
            // servicos_solicitadosTableAdapter
            // 
            this.servicos_solicitadosTableAdapter.ClearBeforeFill = true;
            // 
            // b_searchCliente
            // 
            this.b_searchCliente.Location = new System.Drawing.Point(446, 326);
            this.b_searchCliente.Name = "b_searchCliente";
            this.b_searchCliente.Size = new System.Drawing.Size(133, 23);
            this.b_searchCliente.TabIndex = 14;
            this.b_searchCliente.Text = "Procurar (Por Cliente)";
            this.b_searchCliente.UseVisualStyleBackColor = true;
            this.b_searchCliente.Click += new System.EventHandler(this.b_searchCliente_Click);
            // 
            // tb_cliente
            // 
            this.tb_cliente.Location = new System.Drawing.Point(672, 30);
            this.tb_cliente.Name = "tb_cliente";
            this.tb_cliente.Size = new System.Drawing.Size(100, 20);
            this.tb_cliente.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(612, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cliente:";
            // 
            // b_exibir
            // 
            this.b_exibir.Location = new System.Drawing.Point(195, 326);
            this.b_exibir.Name = "b_exibir";
            this.b_exibir.Size = new System.Drawing.Size(88, 23);
            this.b_exibir.TabIndex = 17;
            this.b_exibir.Text = "Exibir Tudo";
            this.b_exibir.UseVisualStyleBackColor = true;
            this.b_exibir.Click += new System.EventHandler(this.b_exibir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codservDataGridViewTextBoxColumn,
            this.veiculoDataGridViewTextBoxColumn,
            this.anoDataGridViewTextBoxColumn,
            this.descservicoDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.usuarioserDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.servicossolicitadosBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(15, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(757, 234);
            this.dataGridView1.TabIndex = 18;
            // 
            // carhubDataSet3
            // 
            this.carhubDataSet3.DataSetName = "carhubDataSet3";
            this.carhubDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servicossolicitadosBindingSource1
            // 
            this.servicossolicitadosBindingSource1.DataMember = "servicos_solicitados";
            this.servicossolicitadosBindingSource1.DataSource = this.carhubDataSet3;
            // 
            // servicos_solicitadosTableAdapter1
            // 
            this.servicos_solicitadosTableAdapter1.ClearBeforeFill = true;
            // 
            // codservDataGridViewTextBoxColumn
            // 
            this.codservDataGridViewTextBoxColumn.DataPropertyName = "cod_serv";
            this.codservDataGridViewTextBoxColumn.HeaderText = "Código do Serviço";
            this.codservDataGridViewTextBoxColumn.Name = "codservDataGridViewTextBoxColumn";
            this.codservDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // veiculoDataGridViewTextBoxColumn
            // 
            this.veiculoDataGridViewTextBoxColumn.DataPropertyName = "veiculo";
            this.veiculoDataGridViewTextBoxColumn.HeaderText = "Veículo";
            this.veiculoDataGridViewTextBoxColumn.Name = "veiculoDataGridViewTextBoxColumn";
            // 
            // anoDataGridViewTextBoxColumn
            // 
            this.anoDataGridViewTextBoxColumn.DataPropertyName = "ano";
            this.anoDataGridViewTextBoxColumn.HeaderText = "Ano";
            this.anoDataGridViewTextBoxColumn.Name = "anoDataGridViewTextBoxColumn";
            this.anoDataGridViewTextBoxColumn.Width = 60;
            // 
            // descservicoDataGridViewTextBoxColumn
            // 
            this.descservicoDataGridViewTextBoxColumn.DataPropertyName = "desc_servico";
            this.descservicoDataGridViewTextBoxColumn.HeaderText = "Descrição de Serviço";
            this.descservicoDataGridViewTextBoxColumn.Name = "descservicoDataGridViewTextBoxColumn";
            this.descservicoDataGridViewTextBoxColumn.Width = 150;
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "Preço";
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // usuarioserDataGridViewTextBoxColumn
            // 
            this.usuarioserDataGridViewTextBoxColumn.DataPropertyName = "usuario_ser";
            this.usuarioserDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.usuarioserDataGridViewTextBoxColumn.Name = "usuarioserDataGridViewTextBoxColumn";
            // 
            // b_clear
            // 
            this.b_clear.Location = new System.Drawing.Point(594, 326);
            this.b_clear.Name = "b_clear";
            this.b_clear.Size = new System.Drawing.Size(75, 23);
            this.b_clear.TabIndex = 19;
            this.b_clear.Text = "Limpar";
            this.b_clear.UseVisualStyleBackColor = true;
            this.b_clear.Click += new System.EventHandler(this.b_clear_Click);
            // 
            // ServiçosADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(797, 391);
            this.Controls.Add(this.b_clear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.b_exibir);
            this.Controls.Add(this.tb_cliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.b_searchCliente);
            this.Controls.Add(this.tb_status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_preco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.b_searchCod);
            this.Controls.Add(this.b_delete);
            this.Controls.Add(this.b_voltar);
            this.Controls.Add(this.b_update);
            this.Controls.Add(this.tb_cdServ);
            this.Controls.Add(this.label1);
            this.Name = "ServiçosADM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServiçosADM";
            this.Load += new System.EventHandler(this.ServiçosADM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.servicossolicitadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carhubDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carhubDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicossolicitadosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_cdServ;
        private System.Windows.Forms.Button b_update;
        private System.Windows.Forms.Button b_voltar;
        private System.Windows.Forms.Button b_delete;
        private System.Windows.Forms.Button b_searchCod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_preco;
        private System.Windows.Forms.TextBox tb_status;
        private System.Windows.Forms.Label label3;
        private carhubDataSet2 carhubDataSet2;
        private System.Windows.Forms.BindingSource servicossolicitadosBindingSource;
        private carhubDataSet2TableAdapters.servicos_solicitadosTableAdapter servicos_solicitadosTableAdapter;
        private System.Windows.Forms.Button b_searchCliente;
        private System.Windows.Forms.TextBox tb_cliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button b_exibir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private carhubDataSet3 carhubDataSet3;
        private System.Windows.Forms.BindingSource servicossolicitadosBindingSource1;
        private carhubDataSet3TableAdapters.servicos_solicitadosTableAdapter servicos_solicitadosTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codservDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descservicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioserDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button b_clear;
    }
}