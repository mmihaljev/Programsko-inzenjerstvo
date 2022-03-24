namespace Kolodvor1
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPolaziste = new System.Windows.Forms.TextBox();
            this.txtAutoprijevoznik = new System.Windows.Forms.TextBox();
            this.txtOdrediste = new System.Windows.Forms.TextBox();
            this.txtUdaljenost = new System.Windows.Forms.TextBox();
            this.btnLinija = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioRegularna = new System.Windows.Forms.RadioButton();
            this.radioStudent = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkPovratna = new System.Windows.Forms.CheckBox();
            this.checkPrtljaga = new System.Windows.Forms.CheckBox();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.txtBrojKarte = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLinija);
            this.groupBox1.Controls.Add(this.txtUdaljenost);
            this.groupBox1.Controls.Add(this.txtOdrediste);
            this.groupBox1.Controls.Add(this.txtAutoprijevoznik);
            this.groupBox1.Controls.Add(this.txtPolaziste);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 190);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Autobusna linija";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Autoprijevoznik:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Udaljenost (km):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Odredište:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Polazište:";
            // 
            // txtPolaziste
            // 
            this.txtPolaziste.Location = new System.Drawing.Point(120, 25);
            this.txtPolaziste.Name = "txtPolaziste";
            this.txtPolaziste.Size = new System.Drawing.Size(132, 22);
            this.txtPolaziste.TabIndex = 4;
            // 
            // txtAutoprijevoznik
            // 
            this.txtAutoprijevoznik.Location = new System.Drawing.Point(120, 135);
            this.txtAutoprijevoznik.Name = "txtAutoprijevoznik";
            this.txtAutoprijevoznik.Size = new System.Drawing.Size(132, 22);
            this.txtAutoprijevoznik.TabIndex = 5;
            // 
            // txtOdrediste
            // 
            this.txtOdrediste.Location = new System.Drawing.Point(120, 59);
            this.txtOdrediste.Name = "txtOdrediste";
            this.txtOdrediste.Size = new System.Drawing.Size(132, 22);
            this.txtOdrediste.TabIndex = 6;
            // 
            // txtUdaljenost
            // 
            this.txtUdaljenost.Location = new System.Drawing.Point(120, 95);
            this.txtUdaljenost.Name = "txtUdaljenost";
            this.txtUdaljenost.Size = new System.Drawing.Size(57, 22);
            this.txtUdaljenost.TabIndex = 7;
            // 
            // btnLinija
            // 
            this.btnLinija.Location = new System.Drawing.Point(280, 28);
            this.btnLinija.Name = "btnLinija";
            this.btnLinija.Size = new System.Drawing.Size(99, 53);
            this.btnLinija.TabIndex = 8;
            this.btnLinija.Text = "Odaberite liniju";
            this.btnLinija.UseVisualStyleBackColor = true;
            this.btnLinija.Click += new System.EventHandler(this.btnLinija_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioStudent);
            this.groupBox2.Controls.Add(this.radioRegularna);
            this.groupBox2.Location = new System.Drawing.Point(24, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 59);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vrsta karte:";
            // 
            // radioRegularna
            // 
            this.radioRegularna.AutoSize = true;
            this.radioRegularna.Location = new System.Drawing.Point(9, 21);
            this.radioRegularna.Name = "radioRegularna";
            this.radioRegularna.Size = new System.Drawing.Size(131, 21);
            this.radioRegularna.TabIndex = 10;
            this.radioRegularna.TabStop = true;
            this.radioRegularna.Text = "Regularna karta";
            this.radioRegularna.UseVisualStyleBackColor = true;
            // 
            // radioStudent
            // 
            this.radioStudent.AutoSize = true;
            this.radioStudent.Location = new System.Drawing.Point(168, 21);
            this.radioStudent.Name = "radioStudent";
            this.radioStudent.Size = new System.Drawing.Size(136, 21);
            this.radioStudent.TabIndex = 11;
            this.radioStudent.TabStop = true;
            this.radioStudent.Text = "Studentska karta";
            this.radioStudent.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkPrtljaga);
            this.groupBox3.Controls.Add(this.checkPovratna);
            this.groupBox3.Location = new System.Drawing.Point(24, 282);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(333, 58);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ostale opcije:";
            // 
            // checkPovratna
            // 
            this.checkPovratna.AutoSize = true;
            this.checkPovratna.Location = new System.Drawing.Point(9, 21);
            this.checkPovratna.Name = "checkPovratna";
            this.checkPovratna.Size = new System.Drawing.Size(87, 21);
            this.checkPovratna.TabIndex = 0;
            this.checkPovratna.Text = "Povratna";
            this.checkPovratna.UseVisualStyleBackColor = true;
            // 
            // checkPrtljaga
            // 
            this.checkPrtljaga.AutoSize = true;
            this.checkPrtljaga.Location = new System.Drawing.Point(168, 21);
            this.checkPrtljaga.Name = "checkPrtljaga";
            this.checkPrtljaga.Size = new System.Drawing.Size(78, 21);
            this.checkPrtljaga.TabIndex = 1;
            this.checkPrtljaga.Text = "Prtljaga";
            this.checkPrtljaga.UseVisualStyleBackColor = true;
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Location = new System.Drawing.Point(24, 355);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(114, 39);
            this.btnKreiraj.TabIndex = 2;
            this.btnKreiraj.Text = "Kreiraj kartu";
            this.btnKreiraj.UseVisualStyleBackColor = true;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Broj karte:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 407);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cijena karte:";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(334, 404);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(100, 22);
            this.txtCijena.TabIndex = 15;
            // 
            // txtBrojKarte
            // 
            this.txtBrojKarte.Location = new System.Drawing.Point(100, 404);
            this.txtBrojKarte.Name = "txtBrojKarte";
            this.txtBrojKarte.Size = new System.Drawing.Size(100, 22);
            this.txtBrojKarte.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBrojKarte);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLinija;
        private System.Windows.Forms.TextBox txtUdaljenost;
        private System.Windows.Forms.TextBox txtOdrediste;
        private System.Windows.Forms.TextBox txtAutoprijevoznik;
        private System.Windows.Forms.TextBox txtPolaziste;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioStudent;
        private System.Windows.Forms.RadioButton radioRegularna;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkPrtljaga;
        private System.Windows.Forms.CheckBox checkPovratna;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.TextBox txtBrojKarte;
    }
}

