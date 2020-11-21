
namespace CarhubApp
{
    partial class SolicitarServico
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
            this.cadastro_serv = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_desc_serv = new System.Windows.Forms.RichTextBox();
            this.b_cad_serv = new System.Windows.Forms.Button();
            this.b_voltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_veic = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_ano = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cadastro_serv
            // 
            this.cadastro_serv.AutoSize = true;
            this.cadastro_serv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastro_serv.ForeColor = System.Drawing.Color.White;
            this.cadastro_serv.Location = new System.Drawing.Point(28, 28);
            this.cadastro_serv.Name = "cadastro_serv";
            this.cadastro_serv.Size = new System.Drawing.Size(143, 24);
            this.cadastro_serv.TabIndex = 0;
            this.cadastro_serv.Text = "Solicitar Serviço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição \r\ndo Serviço:";
            // 
            // tb_desc_serv
            // 
            this.tb_desc_serv.Location = new System.Drawing.Point(114, 117);
            this.tb_desc_serv.Name = "tb_desc_serv";
            this.tb_desc_serv.Size = new System.Drawing.Size(627, 115);
            this.tb_desc_serv.TabIndex = 7;
            this.tb_desc_serv.Text = "";
            this.tb_desc_serv.TextChanged += new System.EventHandler(this.tb_desc_serv_TextChanged);
            // 
            // b_cad_serv
            // 
            this.b_cad_serv.Location = new System.Drawing.Point(114, 258);
            this.b_cad_serv.Name = "b_cad_serv";
            this.b_cad_serv.Size = new System.Drawing.Size(152, 23);
            this.b_cad_serv.TabIndex = 8;
            this.b_cad_serv.Text = "Solicitar Serviço";
            this.b_cad_serv.UseVisualStyleBackColor = true;
            this.b_cad_serv.Click += new System.EventHandler(this.b_cad_serv_Click);
            // 
            // b_voltar
            // 
            this.b_voltar.Location = new System.Drawing.Point(114, 287);
            this.b_voltar.Name = "b_voltar";
            this.b_voltar.Size = new System.Drawing.Size(152, 23);
            this.b_voltar.TabIndex = 9;
            this.b_voltar.Text = "Voltar";
            this.b_voltar.UseVisualStyleBackColor = true;
            this.b_voltar.Click += new System.EventHandler(this.b_voltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Veículo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_veic
            // 
            this.tb_veic.Location = new System.Drawing.Point(114, 58);
            this.tb_veic.Name = "tb_veic";
            this.tb_veic.Size = new System.Drawing.Size(627, 19);
            this.tb_veic.TabIndex = 11;
            this.tb_veic.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(67, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ano:";
            // 
            // cb_ano
            // 
            this.cb_ano.FormattingEnabled = true;
            this.cb_ano.Items.AddRange(new object[] {
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980",
            "1979",
            "1978",
            "1977",
            "1976",
            "1975",
            "1974",
            "1973",
            "1972",
            "1971",
            "1970"});
            this.cb_ano.Location = new System.Drawing.Point(114, 86);
            this.cb_ano.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_ano.Name = "cb_ano";
            this.cb_ano.Size = new System.Drawing.Size(92, 21);
            this.cb_ano.TabIndex = 14;
            // 
            // SolicitarServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(797, 391);
            this.Controls.Add(this.cb_ano);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_veic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_voltar);
            this.Controls.Add(this.b_cad_serv);
            this.Controls.Add(this.tb_desc_serv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cadastro_serv);
            this.Name = "SolicitarServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Orçamentos";
            this.Load += new System.EventHandler(this.CadastroOrçamentos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cadastro_serv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox tb_desc_serv;
        private System.Windows.Forms.Button b_cad_serv;
        private System.Windows.Forms.Button b_voltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox tb_veic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_ano;
    }
}