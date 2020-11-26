namespace CarhubApp
{
    partial class Serviços
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
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.servicossolicitadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carhubDataSet = new CarhubApp.carhubDataSet();
            this.servicos_solicitadosTableAdapter = new CarhubApp.carhubDataSetTableAdapters.servicos_solicitadosTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.servicossolicitadosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.carhub_servico = new CarhubApp.carhub_servico();
            this.servicos_solicitadosTableAdapter1 = new CarhubApp.carhub_servicoTableAdapters.servicos_solicitadosTableAdapter();
            this.b_adm = new System.Windows.Forms.Button();
            this.veiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descservicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.servicossolicitadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carhubDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicossolicitadosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carhub_servico)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Serviços";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.button6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button6.Location = new System.Drawing.Point(27, 242);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(118, 26);
            this.button6.TabIndex = 6;
            this.button6.Text = "SOLICITAR ORÇAMENTO";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(178, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 26);
            this.button1.TabIndex = 7;
            this.button1.Text = "MARCAR DATA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(27, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 26);
            this.button2.TabIndex = 8;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // servicossolicitadosBindingSource
            // 
            this.servicossolicitadosBindingSource.DataMember = "servicos_solicitados";
            this.servicossolicitadosBindingSource.DataSource = this.carhubDataSet;
            // 
            // carhubDataSet
            // 
            this.carhubDataSet.DataSetName = "carhubDataSet";
            this.carhubDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servicos_solicitadosTableAdapter
            // 
            this.servicos_solicitadosTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.veiculoDataGridViewTextBoxColumn,
            this.descservicoDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.servicossolicitadosBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(27, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(758, 175);
            this.dataGridView1.TabIndex = 9;
            // 
            // servicossolicitadosBindingSource1
            // 
            this.servicossolicitadosBindingSource1.DataMember = "servicos_solicitados";
            this.servicossolicitadosBindingSource1.DataSource = this.carhub_servico;
            // 
            // carhub_servico
            // 
            this.carhub_servico.DataSetName = "carhub_servico";
            this.carhub_servico.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servicos_solicitadosTableAdapter1
            // 
            this.servicos_solicitadosTableAdapter1.ClearBeforeFill = true;
            // 
            // b_adm
            // 
            this.b_adm.Location = new System.Drawing.Point(710, 323);
            this.b_adm.Name = "b_adm";
            this.b_adm.Size = new System.Drawing.Size(75, 26);
            this.b_adm.TabIndex = 11;
            this.b_adm.Text = "Adm";
            this.b_adm.UseVisualStyleBackColor = true;
            this.b_adm.Click += new System.EventHandler(this.b_adm_Click);
            // 
            // veiculoDataGridViewTextBoxColumn
            // 
            this.veiculoDataGridViewTextBoxColumn.DataPropertyName = "veiculo";
            this.veiculoDataGridViewTextBoxColumn.HeaderText = "Veículo";
            this.veiculoDataGridViewTextBoxColumn.Name = "veiculoDataGridViewTextBoxColumn";
            // 
            // descservicoDataGridViewTextBoxColumn
            // 
            this.descservicoDataGridViewTextBoxColumn.DataPropertyName = "desc_servico";
            this.descservicoDataGridViewTextBoxColumn.HeaderText = "Descrição Serviço";
            this.descservicoDataGridViewTextBoxColumn.Name = "descservicoDataGridViewTextBoxColumn";
            this.descservicoDataGridViewTextBoxColumn.Width = 300;
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
            this.statusDataGridViewTextBoxColumn.Width = 200;
            // 
            // Serviços
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(797, 391);
            this.Controls.Add(this.b_adm);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label1);
            this.Name = "Serviços";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serviços";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.servicossolicitadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carhubDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicossolicitadosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carhub_servico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private carhubDataSet carhubDataSet;
        private System.Windows.Forms.BindingSource servicossolicitadosBindingSource;
        private carhubDataSetTableAdapters.servicos_solicitadosTableAdapter servicos_solicitadosTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private carhub_servico carhub_servico;
        private System.Windows.Forms.BindingSource servicossolicitadosBindingSource1;
        private carhub_servicoTableAdapters.servicos_solicitadosTableAdapter servicos_solicitadosTableAdapter1;
        private System.Windows.Forms.Button b_adm;
        private System.Windows.Forms.DataGridViewTextBoxColumn veiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descservicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}