
namespace CarhubApp
{
    partial class ServiçosAgendadosVisualizar
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
            this.DGV_Agenda = new System.Windows.Forms.DataGridView();
            this.codagendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario_ag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carhubDataSet1 = new CarhubApp.carhubDataSet1();
            this.agendaTableAdapter = new CarhubApp.carhubDataSet1TableAdapters.agendaTableAdapter();
            this.b_voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Agenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carhubDataSet1)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Agenda";
            // 
            // DGV_Agenda
            // 
            this.DGV_Agenda.AutoGenerateColumns = false;
            this.DGV_Agenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Agenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codagendaDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.veiculoDataGridViewTextBoxColumn,
            this.anoDataGridViewTextBoxColumn,
            this.usuario_ag});
            this.DGV_Agenda.DataSource = this.agendaBindingSource;
            this.DGV_Agenda.Location = new System.Drawing.Point(27, 64);
            this.DGV_Agenda.Name = "DGV_Agenda";
            this.DGV_Agenda.Size = new System.Drawing.Size(647, 205);
            this.DGV_Agenda.TabIndex = 4;
            // 
            // codagendaDataGridViewTextBoxColumn
            // 
            this.codagendaDataGridViewTextBoxColumn.DataPropertyName = "cod_agenda";
            this.codagendaDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codagendaDataGridViewTextBoxColumn.Name = "codagendaDataGridViewTextBoxColumn";
            this.codagendaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.Width = 150;
            // 
            // veiculoDataGridViewTextBoxColumn
            // 
            this.veiculoDataGridViewTextBoxColumn.DataPropertyName = "veiculo";
            this.veiculoDataGridViewTextBoxColumn.HeaderText = "Veículo";
            this.veiculoDataGridViewTextBoxColumn.Name = "veiculoDataGridViewTextBoxColumn";
            this.veiculoDataGridViewTextBoxColumn.Width = 150;
            // 
            // anoDataGridViewTextBoxColumn
            // 
            this.anoDataGridViewTextBoxColumn.DataPropertyName = "ano";
            this.anoDataGridViewTextBoxColumn.HeaderText = "Ano";
            this.anoDataGridViewTextBoxColumn.Name = "anoDataGridViewTextBoxColumn";
            // 
            // usuario_ag
            // 
            this.usuario_ag.DataPropertyName = "usuario_ag";
            this.usuario_ag.HeaderText = "Usuário";
            this.usuario_ag.Name = "usuario_ag";
            // 
            // agendaBindingSource
            // 
            this.agendaBindingSource.DataMember = "agenda";
            this.agendaBindingSource.DataSource = this.carhubDataSet1;
            // 
            // carhubDataSet1
            // 
            this.carhubDataSet1.DataSetName = "carhubDataSet1";
            this.carhubDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agendaTableAdapter
            // 
            this.agendaTableAdapter.ClearBeforeFill = true;
            // 
            // b_voltar
            // 
            this.b_voltar.Location = new System.Drawing.Point(27, 296);
            this.b_voltar.Name = "b_voltar";
            this.b_voltar.Size = new System.Drawing.Size(75, 23);
            this.b_voltar.TabIndex = 5;
            this.b_voltar.Text = "Voltar";
            this.b_voltar.UseVisualStyleBackColor = true;
            this.b_voltar.Click += new System.EventHandler(this.b_voltar_Click);
            // 
            // ServiçosAgendadosVisualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(797, 391);
            this.Controls.Add(this.b_voltar);
            this.Controls.Add(this.DGV_Agenda);
            this.Controls.Add(this.label1);
            this.Name = "ServiçosAgendadosVisualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServiçosAgendadosVisualizar";
            this.Load += new System.EventHandler(this.ServiçosAgendadosVisualizar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Agenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carhubDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_Agenda;
        private carhubDataSet1 carhubDataSet1;
        private System.Windows.Forms.BindingSource agendaBindingSource;
        private carhubDataSet1TableAdapters.agendaTableAdapter agendaTableAdapter;
        private System.Windows.Forms.Button b_voltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codagendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario_ag;
    }
}