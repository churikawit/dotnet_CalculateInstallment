
namespace CalculateInstallment
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_pv = new System.Windows.Forms.TextBox();
            this.textBox_intrate = new System.Windows.Forms.TextBox();
            this.textBox_term_year = new System.Windows.Forms.TextBox();
            this.textBox_installment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_term_month = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_pv
            // 
            this.textBox_pv.Location = new System.Drawing.Point(130, 37);
            this.textBox_pv.Name = "textBox_pv";
            this.textBox_pv.Size = new System.Drawing.Size(100, 23);
            this.textBox_pv.TabIndex = 0;
            this.textBox_pv.Text = "0";
            // 
            // textBox_intrate
            // 
            this.textBox_intrate.Location = new System.Drawing.Point(130, 78);
            this.textBox_intrate.Name = "textBox_intrate";
            this.textBox_intrate.Size = new System.Drawing.Size(100, 23);
            this.textBox_intrate.TabIndex = 1;
            this.textBox_intrate.Text = "0";
            // 
            // textBox_term_year
            // 
            this.textBox_term_year.Location = new System.Drawing.Point(130, 116);
            this.textBox_term_year.Name = "textBox_term_year";
            this.textBox_term_year.Size = new System.Drawing.Size(100, 23);
            this.textBox_term_year.TabIndex = 2;
            this.textBox_term_year.Text = "0";
            // 
            // textBox_installment
            // 
            this.textBox_installment.Location = new System.Drawing.Point(130, 157);
            this.textBox_installment.Name = "textBox_installment";
            this.textBox_installment.Size = new System.Drawing.Size(100, 23);
            this.textBox_installment.TabIndex = 3;
            this.textBox_installment.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "เงินต้น";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "อัตราดอกเบี้ย";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "ระยะเวลาผ่อนชำระ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "เงินงวดต่อเดือน";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "ปี";
            // 
            // textBox_term_month
            // 
            this.textBox_term_month.Location = new System.Drawing.Point(265, 116);
            this.textBox_term_month.Name = "textBox_term_month";
            this.textBox_term_month.Size = new System.Drawing.Size(100, 23);
            this.textBox_term_month.TabIndex = 9;
            this.textBox_term_month.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "เดือน";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(236, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "ต่อปี";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 287);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_term_month);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_installment);
            this.Controls.Add(this.textBox_term_year);
            this.Controls.Add(this.textBox_intrate);
            this.Controls.Add(this.textBox_pv);
            this.Name = "Form1";
            this.Text = "Find Installment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_pv;
        private System.Windows.Forms.TextBox textBox_intrate;
        private System.Windows.Forms.TextBox textBox_term_year;
        private System.Windows.Forms.TextBox textBox_installment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_term_month;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}

