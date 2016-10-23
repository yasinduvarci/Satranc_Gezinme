namespace Satranc_Gezinme
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
            this.pnlEkran = new System.Windows.Forms.Panel();
            this.btnCiz = new System.Windows.Forms.Button();
            this.rdbYedi = new System.Windows.Forms.RadioButton();
            this.rdbSekiz = new System.Windows.Forms.RadioButton();
            this.rdbDokuz = new System.Windows.Forms.RadioButton();
            this.lblSkor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEkran
            // 
            this.pnlEkran.Location = new System.Drawing.Point(30, 33);
            this.pnlEkran.Name = "pnlEkran";
            this.pnlEkran.Size = new System.Drawing.Size(366, 250);
            this.pnlEkran.TabIndex = 3;
            // 
            // btnCiz
            // 
            this.btnCiz.ForeColor = System.Drawing.Color.Chocolate;
            this.btnCiz.Location = new System.Drawing.Point(469, 44);
            this.btnCiz.Name = "btnCiz";
            this.btnCiz.Size = new System.Drawing.Size(100, 23);
            this.btnCiz.TabIndex = 0;
            this.btnCiz.Text = "Başla";
            this.btnCiz.UseVisualStyleBackColor = true;
            this.btnCiz.Click += new System.EventHandler(this.btnCiz_Click);
            // 
            // rdbYedi
            // 
            this.rdbYedi.AutoSize = true;
            this.rdbYedi.Location = new System.Drawing.Point(72, 31);
            this.rdbYedi.Name = "rdbYedi";
            this.rdbYedi.Size = new System.Drawing.Size(41, 17);
            this.rdbYedi.TabIndex = 1;
            this.rdbYedi.TabStop = true;
            this.rdbYedi.Text = "7*7";
            this.rdbYedi.UseVisualStyleBackColor = true;
            // 
            // rdbSekiz
            // 
            this.rdbSekiz.AutoSize = true;
            this.rdbSekiz.Location = new System.Drawing.Point(72, 64);
            this.rdbSekiz.Name = "rdbSekiz";
            this.rdbSekiz.Size = new System.Drawing.Size(41, 17);
            this.rdbSekiz.TabIndex = 1;
            this.rdbSekiz.TabStop = true;
            this.rdbSekiz.Text = "8*8";
            this.rdbSekiz.UseVisualStyleBackColor = true;
            // 
            // rdbDokuz
            // 
            this.rdbDokuz.AutoSize = true;
            this.rdbDokuz.Location = new System.Drawing.Point(72, 101);
            this.rdbDokuz.Name = "rdbDokuz";
            this.rdbDokuz.Size = new System.Drawing.Size(41, 17);
            this.rdbDokuz.TabIndex = 1;
            this.rdbDokuz.TabStop = true;
            this.rdbDokuz.Text = "9*9";
            this.rdbDokuz.UseVisualStyleBackColor = true;
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkor.Location = new System.Drawing.Point(169, 297);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(46, 20);
            this.lblSkor.TabIndex = 2;
            this.lblSkor.Text = "Skor";
            this.lblSkor.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbYedi);
            this.groupBox1.Controls.Add(this.rdbSekiz);
            this.groupBox1.Controls.Add(this.rdbDokuz);
            this.groupBox1.Location = new System.Drawing.Point(426, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 171);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kare Belirle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 373);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlEkran);
            this.Controls.Add(this.lblSkor);
            this.Controls.Add(this.btnCiz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlEkran;
        private System.Windows.Forms.Button btnCiz;
        private System.Windows.Forms.RadioButton rdbYedi;
        private System.Windows.Forms.RadioButton rdbSekiz;
        private System.Windows.Forms.RadioButton rdbDokuz;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

