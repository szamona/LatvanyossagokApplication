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
            this.buttonHozzaad = new System.Windows.Forms.Button();
            this.numericUpDownLakossag = new System.Windows.Forms.NumericUpDown();
            this.listBoxVarosok = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLakossag)).BeginInit();
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
            this.textBoxVarosok.Size = new System.Drawing.Size(91, 20);
            this.textBoxVarosok.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBoxVarosok);
            this.panel1.Controls.Add(this.buttonHozzaad);
            this.panel1.Controls.Add(this.numericUpDownLakossag);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxVarosok);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 221);
            this.panel1.TabIndex = 4;
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
            this.numericUpDownLakossag.Name = "numericUpDownLakossag";
            this.numericUpDownLakossag.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownLakossag.TabIndex = 3;
            // 
            // listBoxVarosok
            // 
            this.listBoxVarosok.FormattingEnabled = true;
            this.listBoxVarosok.Location = new System.Drawing.Point(36, 108);
            this.listBoxVarosok.Name = "listBoxVarosok";
            this.listBoxVarosok.Size = new System.Drawing.Size(137, 108);
            this.listBoxVarosok.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLakossag)).EndInit();
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
    }
}

