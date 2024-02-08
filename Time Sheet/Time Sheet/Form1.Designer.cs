namespace Time_Sheet
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ThursdayTimes = new System.Windows.Forms.TextBox();
            this.ThursdayTotal = new System.Windows.Forms.TextBox();
            this.FridayTimes = new System.Windows.Forms.TextBox();
            this.FridayTotal = new System.Windows.Forms.TextBox();
            this.SaturdayTimes = new System.Windows.Forms.TextBox();
            this.SaturdayTotal = new System.Windows.Forms.TextBox();
            this.SundayTimes = new System.Windows.Forms.TextBox();
            this.SundayTotal = new System.Windows.Forms.TextBox();
            this.MondayTimes = new System.Windows.Forms.TextBox();
            this.MondayTotal = new System.Windows.Forms.TextBox();
            this.TuesdayTimes = new System.Windows.Forms.TextBox();
            this.TuesdayTotal = new System.Windows.Forms.TextBox();
            this.WednesdayTimes = new System.Windows.Forms.TextBox();
            this.WednesdayTotal = new System.Windows.Forms.TextBox();
            this.TotalWeeklyHours = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.sendbutton = new System.Windows.Forms.Button();
            this.WednesdayEndTimes = new System.Windows.Forms.TextBox();
            this.TuesdayEndTimes = new System.Windows.Forms.TextBox();
            this.MondayEndTimes = new System.Windows.Forms.TextBox();
            this.SundayEndTimes = new System.Windows.Forms.TextBox();
            this.SaturdayEndTimes = new System.Windows.Forms.TextBox();
            this.FridayEndTimes = new System.Windows.Forms.TextBox();
            this.ThursdayEndTimes = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Clock In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(257, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Clock Out";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Thursday";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Friday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Saturday";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Sunday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Monday";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tuesday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Wednesday";
            // 
            // ThursdayTimes
            // 
            this.ThursdayTimes.Location = new System.Drawing.Point(82, 25);
            this.ThursdayTimes.Name = "ThursdayTimes";
            this.ThursdayTimes.Size = new System.Drawing.Size(68, 20);
            this.ThursdayTimes.TabIndex = 17;
            // 
            // ThursdayTotal
            // 
            this.ThursdayTotal.Location = new System.Drawing.Point(232, 25);
            this.ThursdayTotal.Name = "ThursdayTotal";
            this.ThursdayTotal.Size = new System.Drawing.Size(100, 20);
            this.ThursdayTotal.TabIndex = 18;
            // 
            // FridayTimes
            // 
            this.FridayTimes.Location = new System.Drawing.Point(82, 51);
            this.FridayTimes.Name = "FridayTimes";
            this.FridayTimes.Size = new System.Drawing.Size(68, 20);
            this.FridayTimes.TabIndex = 19;
            // 
            // FridayTotal
            // 
            this.FridayTotal.Location = new System.Drawing.Point(232, 51);
            this.FridayTotal.Name = "FridayTotal";
            this.FridayTotal.Size = new System.Drawing.Size(100, 20);
            this.FridayTotal.TabIndex = 20;
            // 
            // SaturdayTimes
            // 
            this.SaturdayTimes.Location = new System.Drawing.Point(82, 77);
            this.SaturdayTimes.Name = "SaturdayTimes";
            this.SaturdayTimes.Size = new System.Drawing.Size(68, 20);
            this.SaturdayTimes.TabIndex = 21;
            this.SaturdayTimes.TextChanged += new System.EventHandler(this.SaturdayTimes_TextChanged);
            // 
            // SaturdayTotal
            // 
            this.SaturdayTotal.Location = new System.Drawing.Point(232, 77);
            this.SaturdayTotal.Name = "SaturdayTotal";
            this.SaturdayTotal.Size = new System.Drawing.Size(100, 20);
            this.SaturdayTotal.TabIndex = 22;
            // 
            // SundayTimes
            // 
            this.SundayTimes.Location = new System.Drawing.Point(82, 103);
            this.SundayTimes.Name = "SundayTimes";
            this.SundayTimes.Size = new System.Drawing.Size(68, 20);
            this.SundayTimes.TabIndex = 23;
            // 
            // SundayTotal
            // 
            this.SundayTotal.Location = new System.Drawing.Point(232, 103);
            this.SundayTotal.Name = "SundayTotal";
            this.SundayTotal.Size = new System.Drawing.Size(100, 20);
            this.SundayTotal.TabIndex = 24;
            // 
            // MondayTimes
            // 
            this.MondayTimes.Location = new System.Drawing.Point(82, 129);
            this.MondayTimes.Name = "MondayTimes";
            this.MondayTimes.Size = new System.Drawing.Size(68, 20);
            this.MondayTimes.TabIndex = 25;
            // 
            // MondayTotal
            // 
            this.MondayTotal.Location = new System.Drawing.Point(232, 129);
            this.MondayTotal.Name = "MondayTotal";
            this.MondayTotal.Size = new System.Drawing.Size(100, 20);
            this.MondayTotal.TabIndex = 26;
            // 
            // TuesdayTimes
            // 
            this.TuesdayTimes.Location = new System.Drawing.Point(82, 155);
            this.TuesdayTimes.Name = "TuesdayTimes";
            this.TuesdayTimes.Size = new System.Drawing.Size(68, 20);
            this.TuesdayTimes.TabIndex = 27;
            // 
            // TuesdayTotal
            // 
            this.TuesdayTotal.Location = new System.Drawing.Point(232, 155);
            this.TuesdayTotal.Name = "TuesdayTotal";
            this.TuesdayTotal.Size = new System.Drawing.Size(100, 20);
            this.TuesdayTotal.TabIndex = 28;
            // 
            // WednesdayTimes
            // 
            this.WednesdayTimes.Location = new System.Drawing.Point(82, 181);
            this.WednesdayTimes.Name = "WednesdayTimes";
            this.WednesdayTimes.Size = new System.Drawing.Size(68, 20);
            this.WednesdayTimes.TabIndex = 29;
            // 
            // WednesdayTotal
            // 
            this.WednesdayTotal.Location = new System.Drawing.Point(232, 181);
            this.WednesdayTotal.Name = "WednesdayTotal";
            this.WednesdayTotal.Size = new System.Drawing.Size(100, 20);
            this.WednesdayTotal.TabIndex = 30;
            // 
            // TotalWeeklyHours
            // 
            this.TotalWeeklyHours.Location = new System.Drawing.Point(232, 207);
            this.TotalWeeklyHours.Name = "TotalWeeklyHours";
            this.TotalWeeklyHours.Size = new System.Drawing.Size(100, 20);
            this.TotalWeeklyHours.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(125, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Total Weekly Hours";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(442, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Description of Work Completed";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(79, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Start Times";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(229, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Total Daily Hours";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(338, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(378, 202);
            this.richTextBox1.TabIndex = 37;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // sendbutton
            // 
            this.sendbutton.Location = new System.Drawing.Point(535, 271);
            this.sendbutton.Name = "sendbutton";
            this.sendbutton.Size = new System.Drawing.Size(181, 23);
            this.sendbutton.TabIndex = 38;
            this.sendbutton.Text = "Send to Team";
            this.sendbutton.UseVisualStyleBackColor = true;
            this.sendbutton.Click += new System.EventHandler(this.sendbutton_Click);
            // 
            // WednesdayEndTimes
            // 
            this.WednesdayEndTimes.Location = new System.Drawing.Point(157, 181);
            this.WednesdayEndTimes.Name = "WednesdayEndTimes";
            this.WednesdayEndTimes.Size = new System.Drawing.Size(68, 20);
            this.WednesdayEndTimes.TabIndex = 45;
            // 
            // TuesdayEndTimes
            // 
            this.TuesdayEndTimes.Location = new System.Drawing.Point(157, 155);
            this.TuesdayEndTimes.Name = "TuesdayEndTimes";
            this.TuesdayEndTimes.Size = new System.Drawing.Size(68, 20);
            this.TuesdayEndTimes.TabIndex = 44;
            // 
            // MondayEndTimes
            // 
            this.MondayEndTimes.Location = new System.Drawing.Point(157, 129);
            this.MondayEndTimes.Name = "MondayEndTimes";
            this.MondayEndTimes.Size = new System.Drawing.Size(68, 20);
            this.MondayEndTimes.TabIndex = 43;
            // 
            // SundayEndTimes
            // 
            this.SundayEndTimes.Location = new System.Drawing.Point(157, 103);
            this.SundayEndTimes.Name = "SundayEndTimes";
            this.SundayEndTimes.Size = new System.Drawing.Size(68, 20);
            this.SundayEndTimes.TabIndex = 42;
            // 
            // SaturdayEndTimes
            // 
            this.SaturdayEndTimes.Location = new System.Drawing.Point(157, 77);
            this.SaturdayEndTimes.Name = "SaturdayEndTimes";
            this.SaturdayEndTimes.Size = new System.Drawing.Size(68, 20);
            this.SaturdayEndTimes.TabIndex = 41;
            // 
            // FridayEndTimes
            // 
            this.FridayEndTimes.Location = new System.Drawing.Point(157, 51);
            this.FridayEndTimes.Name = "FridayEndTimes";
            this.FridayEndTimes.Size = new System.Drawing.Size(68, 20);
            this.FridayEndTimes.TabIndex = 40;
            // 
            // ThursdayEndTimes
            // 
            this.ThursdayEndTimes.Location = new System.Drawing.Point(157, 25);
            this.ThursdayEndTimes.Name = "ThursdayEndTimes";
            this.ThursdayEndTimes.Size = new System.Drawing.Size(68, 20);
            this.ThursdayEndTimes.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(154, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 46;
            this.label12.Text = "End Times";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 306);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.WednesdayEndTimes);
            this.Controls.Add(this.TuesdayEndTimes);
            this.Controls.Add(this.MondayEndTimes);
            this.Controls.Add(this.SundayEndTimes);
            this.Controls.Add(this.SaturdayEndTimes);
            this.Controls.Add(this.FridayEndTimes);
            this.Controls.Add(this.ThursdayEndTimes);
            this.Controls.Add(this.sendbutton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TotalWeeklyHours);
            this.Controls.Add(this.WednesdayTotal);
            this.Controls.Add(this.WednesdayTimes);
            this.Controls.Add(this.TuesdayTotal);
            this.Controls.Add(this.TuesdayTimes);
            this.Controls.Add(this.MondayTotal);
            this.Controls.Add(this.MondayTimes);
            this.Controls.Add(this.SundayTotal);
            this.Controls.Add(this.SundayTimes);
            this.Controls.Add(this.SaturdayTotal);
            this.Controls.Add(this.SaturdayTimes);
            this.Controls.Add(this.FridayTotal);
            this.Controls.Add(this.FridayTimes);
            this.Controls.Add(this.ThursdayTotal);
            this.Controls.Add(this.ThursdayTimes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ThursdayTimes;
        private System.Windows.Forms.TextBox ThursdayTotal;
        private System.Windows.Forms.TextBox FridayTimes;
        private System.Windows.Forms.TextBox FridayTotal;
        private System.Windows.Forms.TextBox SaturdayTimes;
        private System.Windows.Forms.TextBox SaturdayTotal;
        private System.Windows.Forms.TextBox SundayTimes;
        private System.Windows.Forms.TextBox SundayTotal;
        private System.Windows.Forms.TextBox MondayTimes;
        private System.Windows.Forms.TextBox MondayTotal;
        private System.Windows.Forms.TextBox TuesdayTimes;
        private System.Windows.Forms.TextBox TuesdayTotal;
        private System.Windows.Forms.TextBox WednesdayTimes;
        private System.Windows.Forms.TextBox WednesdayTotal;
        private System.Windows.Forms.TextBox TotalWeeklyHours;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button sendbutton;
        private System.Windows.Forms.TextBox WednesdayEndTimes;
        private System.Windows.Forms.TextBox TuesdayEndTimes;
        private System.Windows.Forms.TextBox MondayEndTimes;
        private System.Windows.Forms.TextBox SundayEndTimes;
        private System.Windows.Forms.TextBox SaturdayEndTimes;
        private System.Windows.Forms.TextBox FridayEndTimes;
        private System.Windows.Forms.TextBox ThursdayEndTimes;
        private System.Windows.Forms.Label label12;
    }
}

