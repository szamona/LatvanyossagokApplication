namespace LatvanyossagokApplication
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxVarosok = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonTorol = new System.Windows.Forms.Button();
            this.listBoxVarosok = new System.Windows.Forms.ListBox();
            this.buttonHozzaad = new System.Windows.Forms.Button();
            this.numericUpDownLakossag = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBoxLatvanyossagok = new System.Windows.Forms.ListBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.textBoxLatvanyossagNev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLatvanyossagLeiras = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownLatvanyossagAr = new System.Windows.Forms.NumericUpDown();
            this.buttonLHozzaad = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLakossag)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLatvanyossagAr)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Város nev:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lakosság száma:";
            // 
            // textBoxVarosok
            // 
            this.textBoxVarosok.Location = new System.Drawing.Point(97, 14);
            this.textBoxVarosok.Name = "textBoxVarosok";
            this.textBoxVarosok.Size = new System.Drawing.Size(137, 20);
            this.textBoxVarosok.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.buttonTorol);
            this.panel1.Controls.Add(this.listBoxVarosok);
            this.panel1.Controls.Add(this.buttonHozzaad);
            this.panel1.Controls.Add(this.numericUpDownLakossag);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxVarosok);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 242);
            this.panel1.TabIndex = 4;
            // 
            // buttonTorol
            // 
            this.buttonTorol.Location = new System.Drawing.Point(0, 209);
            this.buttonTorol.Name = "buttonTorol";
            this.buttonTorol.Size = new System.Drawing.Size(75, 23);
            this.buttonTorol.TabIndex = 6;
            this.buttonTorol.Text = "Törlés";
            this.buttonTorol.UseVisualStyleBackColor = true;
            this.buttonTorol.Click += new System.EventHandler(this.ButtonTorol_Click);
            // 
            // listBoxVarosok
            // 
            this.listBoxVarosok.FormattingEnabled = true;
            this.listBoxVarosok.Location = new System.Drawing.Point(3, 108);
            this.listBoxVarosok.Name = "listBoxVarosok";
            this.listBoxVarosok.Size = new System.Drawing.Size(137, 95);
            this.listBoxVarosok.TabIndex = 5;
            // 
            // buttonHozzaad
            // 
            this.buttonHozzaad.Location = new System.Drawing.Point(98, 69);
            this.buttonHozzaad.Name = "buttonHozzaad";
            this.buttonHozzaad.Size = new System.Drawing.Size(75, 23);
            this.buttonHozzaad.TabIndex = 5;
            this.buttonHozzaad.Text = "Hozzáadás";
            this.buttonHozzaad.UseVisualStyleBackColor = true;
            this.buttonHozzaad.Click += new System.EventHandler(this.ButtonHozzaad_Click);
            // 
            // numericUpDownLakossag
            // 
            this.numericUpDownLakossag.Location = new System.Drawing.Point(98, 43);
            this.numericUpDownLakossag.Maximum = new decimal(new int[] {
            1661992960,
            1808227885,
            5,
            0});
            this.numericUpDownLakossag.Name = "numericUpDownLakossag";
            this.numericUpDownLakossag.Size = new System.Drawing.Size(105, 20);
            this.numericUpDownLakossag.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonLHozzaad);
            this.panel2.Controls.Add(this.numericUpDownLatvanyossagAr);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBoxLatvanyossagLeiras);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBoxLatvanyossagNev);
            this.panel2.Controls.Add(this.lbl1);
            this.panel2.Controls.Add(this.listBoxLatvanyossagok);
            this.panel2.Location = new System.Drawing.Point(12, 260);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(359, 250);
            this.panel2.TabIndex = 5;
            // 
            // listBoxLatvanyossagok
            // 
            this.listBoxLatvanyossagok.FormattingEnabled = true;
            this.listBoxLatvanyossagok.Location = new System.Drawing.Point(121, 116);
            this.listBoxLatvanyossagok.Name = "listBoxLatvanyossagok";
            this.listBoxLatvanyossagok.Size = new System.Drawing.Size(137, 95);
            this.listBoxLatvanyossagok.TabIndex = 6;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(19, 29);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(103, 13);
            this.lbl1.TabIndex = 7;
            this.lbl1.Text = "Látványosság neve:";
            // 
            // textBoxLatvanyossagNev
            // 
            this.textBoxLatvanyossagNev.Location = new System.Drawing.Point(128, 26);
            this.textBoxLatvanyossagNev.Name = "textBoxLatvanyossagNev";
            this.textBoxLatvanyossagNev.Size = new System.Drawing.Size(130, 20);
            this.textBoxLatvanyossagNev.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Leírás:";
            // 
            // textBoxLatvanyossagLeiras
            // 
            this.textBoxLatvanyossagLeiras.Location = new System.Drawing.Point(128, 60);
            this.textBoxLatvanyossagLeiras.Name = "textBoxLatvanyossagLeiras";
            this.textBoxLatvanyossagLeiras.Size = new System.Drawing.Size(130, 20);
            this.textBoxLatvanyossagLeiras.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ár:";
            // 
            // numericUpDownLatvanyossagAr
            // 
            this.numericUpDownLatvanyossagAr.Location = new System.Drawing.Point(128, 90);
            this.numericUpDownLatvanyossagAr.Maximum = new decimal(new int[] {
            1241513984,
            370409800,
            542101,
            0});
            this.numericUpDownLatvanyossagAr.Name = "numericUpDownLatvanyossagAr";
            this.numericUpDownLatvanyossagAr.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownLatvanyossagAr.TabIndex = 11;
            // 
            // buttonLHozzaad
            // 
            this.buttonLHozzaad.Location = new System.Drawing.Point(22, 116);
            this.buttonLHozzaad.Name = "buttonLHozzaad";
            this.buttonLHozzaad.Size = new System.Drawing.Size(75, 23);
            this.buttonLHozzaad.TabIndex = 12;
            this.buttonLHozzaad.Text = "Hozzáadás";
            this.buttonLHozzaad.UseVisualStyleBackColor = true;
            this.buttonLHozzaad.Click += new System.EventHandler(this.ButtonLHozzaad_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(146, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Latvanyossagok";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLakossag)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLatvanyossagAr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxVarosok;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonHozzaad;
        private System.Windows.Forms.NumericUpDown numericUpDownLakossag;
        private System.Windows.Forms.ListBox listBoxVarosok;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonTorol;
        private System.Windows.Forms.NumericUpDown numericUpDownLatvanyossagAr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLatvanyossagLeiras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLatvanyossagNev;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.ListBox listBoxLatvanyossagok;
        private System.Windows.Forms.Button buttonLHozzaad;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

