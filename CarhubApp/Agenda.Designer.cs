
namespace CarhubApp
{
    partial class Agenda
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.AnoComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InputVeiculo = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PegarDataBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.b_visuA = new System.Windows.Forms.Button();
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
            this.label1.TabIndex = 10;
            this.label1.Text = "Agenda";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(27, 86);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 11;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // AnoComboBox
            // 
            this.AnoComboBox.FormattingEnabled = true;
            this.AnoComboBox.Items.AddRange(new object[] {
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
            this.AnoComboBox.Location = new System.Drawing.Point(321, 114);
            this.AnoComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AnoComboBox.Name = "AnoComboBox";
            this.AnoComboBox.Size = new System.Drawing.Size(70, 21);
            this.AnoComboBox.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(274, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ano:";
            // 
            // InputVeiculo
            // 
            this.InputVeiculo.Location = new System.Drawing.Point(321, 86);
            this.InputVeiculo.Name = "InputVeiculo";
            this.InputVeiculo.Size = new System.Drawing.Size(123, 19);
            this.InputVeiculo.TabIndex = 16;
            this.InputVeiculo.Text = "";
            this.InputVeiculo.TextChanged += new System.EventHandler(this.InputVeiculo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(258, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Veículo:";
            // 
            // PegarDataBtn
            // 
            this.PegarDataBtn.Location = new System.Drawing.Point(321, 141);
            this.PegarDataBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PegarDataBtn.Name = "PegarDataBtn";
            this.PegarDataBtn.Size = new System.Drawing.Size(122, 47);
            this.PegarDataBtn.TabIndex = 19;
            this.PegarDataBtn.Text = "Agendar na data selecionada";
            this.PegarDataBtn.UseVisualStyleBackColor = true;
            this.PegarDataBtn.Click += new System.EventHandler(this.PegarDataBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(372, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Aqui você pode agendar uma data para fazer uma visitinha ao seu mecânico.";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(189, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 26);
            this.button2.TabIndex = 22;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // b_visuA
            // 
            this.b_visuA.Location = new System.Drawing.Point(28, 279);
            this.b_visuA.Name = "b_visuA";
            this.b_visuA.Size = new System.Drawing.Size(133, 26);
            this.b_visuA.TabIndex = 23;
            this.b_visuA.Text = "Visualizar Agendamentos";
            this.b_visuA.UseVisualStyleBackColor = true;
            this.b_visuA.Click += new System.EventHandler(this.b_visuA_Click);
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(797, 391);
            this.Controls.Add(this.b_visuA);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PegarDataBtn);
            this.Controls.Add(this.AnoComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InputVeiculo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label1);
            this.Name = "Agenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox AnoComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox InputVeiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PegarDataBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button b_visuA;
    }
}