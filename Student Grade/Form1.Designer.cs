namespace Student_Grade
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TextName = new System.Windows.Forms.TextBox();
            this.textEnglish = new System.Windows.Forms.TextBox();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.textScience = new System.Windows.Forms.TextBox();
            this.textMaths = new System.Windows.Forms.TextBox();
            this.textAvg = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textGrade = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(454, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Grade";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textGrade);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textAvg);
            this.groupBox1.Controls.Add(this.textMaths);
            this.groupBox1.Controls.Add(this.textScience);
            this.groupBox1.Controls.Add(this.textTotal);
            this.groupBox1.Controls.Add(this.textEnglish);
            this.groupBox1.Controls.Add(this.TextName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(270, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 446);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Grade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "English";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Science";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Maths";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Avg";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total";
            // 
            // TextName
            // 
            this.TextName.Location = new System.Drawing.Point(137, 42);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(253, 22);
            this.TextName.TabIndex = 7;
            // 
            // textEnglish
            // 
            this.textEnglish.Location = new System.Drawing.Point(137, 186);
            this.textEnglish.Name = "textEnglish";
            this.textEnglish.Size = new System.Drawing.Size(253, 22);
            this.textEnglish.TabIndex = 8;
            // 
            // textTotal
            // 
            this.textTotal.Location = new System.Drawing.Point(137, 232);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(253, 22);
            this.textTotal.TabIndex = 9;
            // 
            // textScience
            // 
            this.textScience.Location = new System.Drawing.Point(137, 149);
            this.textScience.Name = "textScience";
            this.textScience.Size = new System.Drawing.Size(253, 22);
            this.textScience.TabIndex = 10;
            // 
            // textMaths
            // 
            this.textMaths.Location = new System.Drawing.Point(137, 103);
            this.textMaths.Name = "textMaths";
            this.textMaths.Size = new System.Drawing.Size(253, 22);
            this.textMaths.TabIndex = 11;
            // 
            // textAvg
            // 
            this.textAvg.Location = new System.Drawing.Point(137, 280);
            this.textAvg.Name = "textAvg";
            this.textAvg.Size = new System.Drawing.Size(253, 22);
            this.textAvg.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Grade";
            // 
            // textGrade
            // 
            this.textGrade.Location = new System.Drawing.Point(137, 339);
            this.textGrade.Name = "textGrade";
            this.textGrade.Size = new System.Drawing.Size(253, 22);
            this.textGrade.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(472, 520);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 688);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textAvg;
        private System.Windows.Forms.TextBox textMaths;
        private System.Windows.Forms.TextBox textScience;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.TextBox textEnglish;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textGrade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}

