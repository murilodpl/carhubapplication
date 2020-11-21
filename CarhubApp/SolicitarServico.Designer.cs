
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cadastro_serv
            // 
            this.cadastro_serv.AutoSize = true;
            this.cadastro_serv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastro_serv.ForeColor = System.Drawing.Color.White;
            this.cadastro_serv.Location = new System.Drawing.Point(37, 34);
            this.cadastro_serv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cadastro_serv.Name = "cadastro_serv";
            this.cadastro_serv.Size = new System.Drawing.Size(187, 29);
            this.cadastro_serv.TabIndex = 0;
            this.cadastro_serv.Text = "Solicitar Serviço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(51, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição:";
            // 
            // tb_desc_serv
            // 
            this.tb_desc_serv.Location = new System.Drawing.Point(152, 144);
            this.tb_desc_serv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_desc_serv.Name = "tb_desc_serv";
            this.tb_desc_serv.Size = new System.Drawing.Size(835, 141);
            this.tb_desc_serv.TabIndex = 7;
            this.tb_desc_serv.Text = "";
            this.tb_desc_serv.TextChanged += new System.EventHandler(this.tb_desc_serv_TextChanged);
            // 
            // b_cad_serv
            // 
            this.b_cad_serv.Location = new System.Drawing.Point(152, 318);
            this.b_cad_serv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b_cad_serv.Name = "b_cad_serv";
            this.b_cad_serv.Size = new System.Drawing.Size(203, 28);
            this.b_cad_serv.TabIndex = 8;
            this.b_cad_serv.Text = "Solicitar Serviço";
            this.b_cad_serv.UseVisualStyleBackColor = true;
            this.b_cad_serv.Click += new System.EventHandler(this.b_cad_serv_Click);
            // 
            // b_voltar
            // 
            this.b_voltar.Location = new System.Drawing.Point(152, 353);
            this.b_voltar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b_voltar.Name = "b_voltar";
            this.b_voltar.Size = new System.Drawing.Size(203, 28);
            this.b_voltar.TabIndex = 9;
            this.b_voltar.Text = "Voltar";
            this.b_voltar.UseVisualStyleBackColor = true;
            this.b_voltar.Click += new System.EventHandler(this.b_voltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Veículo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(152, 72);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(835, 23);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(89, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ano:";
            // 
            // SolicitarServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1063, 481);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_voltar);
            this.Controls.Add(this.b_cad_serv);
            this.Controls.Add(this.tb_desc_serv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cadastro_serv);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
    }
}