namespace CarhubApp
{
    partial class Carhub
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carhub));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.b_login = new System.Windows.Forms.Button();
            this.b_agenda = new System.Windows.Forms.Button();
            this.b_prog = new System.Windows.Forms.Button();
            this.b_serv = new System.Windows.Forms.Button();
            this.b_home = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.l_agenda = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.l_servico = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.b_login);
            this.splitContainer1.Panel1.Controls.Add(this.b_agenda);
            this.splitContainer1.Panel1.Controls.Add(this.b_prog);
            this.splitContainer1.Panel1.Controls.Add(this.b_serv);
            this.splitContainer1.Panel1.Controls.Add(this.b_home);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.l_servico);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.l_agenda);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarhubApp.Properties.Resources.Design_sem_nome__1_;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // b_login
            // 
            resources.ApplyResources(this.b_login, "b_login");
            this.b_login.Name = "b_login";
            this.b_login.UseVisualStyleBackColor = true;
            this.b_login.Click += new System.EventHandler(this.button5_Click);
            // 
            // b_agenda
            // 
            resources.ApplyResources(this.b_agenda, "b_agenda");
            this.b_agenda.Name = "b_agenda";
            this.b_agenda.UseVisualStyleBackColor = true;
            this.b_agenda.Click += new System.EventHandler(this.button4_Click);
            // 
            // b_prog
            // 
            resources.ApplyResources(this.b_prog, "b_prog");
            this.b_prog.Name = "b_prog";
            this.b_prog.UseVisualStyleBackColor = true;
            this.b_prog.Click += new System.EventHandler(this.ProgressoBtn_Click);
            // 
            // b_serv
            // 
            resources.ApplyResources(this.b_serv, "b_serv");
            this.b_serv.Name = "b_serv";
            this.b_serv.UseVisualStyleBackColor = true;
            this.b_serv.Click += new System.EventHandler(this.ServicosBtn_Click);
            // 
            // b_home
            // 
            resources.ApplyResources(this.b_home, "b_home");
            this.b_home.Name = "b_home";
            this.b_home.UseVisualStyleBackColor = true;
            this.b_home.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // l_agenda
            // 
            resources.ApplyResources(this.l_agenda, "l_agenda");
            this.l_agenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.l_agenda.Name = "l_agenda";
            this.l_agenda.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // l_servico
            // 
            resources.ApplyResources(this.l_servico, "l_servico");
            this.l_servico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.l_servico.Name = "l_servico";
            this.l_servico.Click += new System.EventHandler(this.label4_Click);
            // 
            // Carhub
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.splitContainer1);
            this.Name = "Carhub";
            this.Load += new System.EventHandler(this.Carhub_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button b_serv;
        private System.Windows.Forms.Button b_home;
        private System.Windows.Forms.Button b_agenda;
        private System.Windows.Forms.Button b_prog;
        private System.Windows.Forms.Button b_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_agenda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label l_servico;
    }
}

