
namespace CarhubApp
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_usuario = new System.Windows.Forms.TextBox();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.b_login = new System.Windows.Forms.Button();
            this.b_voltar = new System.Windows.Forms.Button();
            this.b_cadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(355, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(176, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(176, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Usuário";
            // 
            // tb_usuario
            // 
            this.tb_usuario.Location = new System.Drawing.Point(269, 134);
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.Size = new System.Drawing.Size(325, 20);
            this.tb_usuario.TabIndex = 5;
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(269, 182);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.Size = new System.Drawing.Size(325, 20);
            this.tb_senha.TabIndex = 6;
            // 
            // b_login
            // 
            this.b_login.Location = new System.Drawing.Point(231, 242);
            this.b_login.Name = "b_login";
            this.b_login.Size = new System.Drawing.Size(95, 29);
            this.b_login.TabIndex = 7;
            this.b_login.Text = "Logar";
            this.b_login.UseVisualStyleBackColor = true;
            this.b_login.Click += new System.EventHandler(this.b_login_Click);
            // 
            // b_voltar
            // 
            this.b_voltar.Location = new System.Drawing.Point(468, 242);
            this.b_voltar.Name = "b_voltar";
            this.b_voltar.Size = new System.Drawing.Size(95, 29);
            this.b_voltar.TabIndex = 9;
            this.b_voltar.Text = "Voltar";
            this.b_voltar.UseVisualStyleBackColor = true;
            this.b_voltar.Click += new System.EventHandler(this.b_voltar_Click);
            // 
            // b_cadastrar
            // 
            this.b_cadastrar.Location = new System.Drawing.Point(350, 242);
            this.b_cadastrar.Name = "b_cadastrar";
            this.b_cadastrar.Size = new System.Drawing.Size(95, 29);
            this.b_cadastrar.TabIndex = 10;
            this.b_cadastrar.Text = "Cadastrar";
            this.b_cadastrar.UseVisualStyleBackColor = true;
            this.b_cadastrar.Click += new System.EventHandler(this.b_cadastrar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(797, 391);
            this.Controls.Add(this.b_cadastrar);
            this.Controls.Add(this.b_voltar);
            this.Controls.Add(this.b_login);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.tb_usuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_usuario;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.Button b_login;
        private System.Windows.Forms.Button b_voltar;
        private System.Windows.Forms.Button b_cadastrar;
    }
}