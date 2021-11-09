
namespace MouseControl
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
            this.scrool_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.delay_progressBar = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.ms_sleep_time_textBox = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.iteration_number_textBox = new System.Windows.Forms.TextBox();
            this.scroll_step_textBox = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.delay_ms_textBox = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // scrool_button
            // 
            this.scrool_button.Location = new System.Drawing.Point(12, 473);
            this.scrool_button.Name = "scrool_button";
            this.scrool_button.Size = new System.Drawing.Size(206, 53);
            this.scrool_button.TabIndex = 0;
            this.scrool_button.Text = "Scroll";
            this.scrool_button.UseVisualStyleBackColor = true;
            this.scrool_button.Click += new System.EventHandler(this.scrool_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(467, 70);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(321, 397);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // delay_progressBar
            // 
            this.delay_progressBar.Location = new System.Drawing.Point(467, 12);
            this.delay_progressBar.Name = "delay_progressBar";
            this.delay_progressBar.Size = new System.Drawing.Size(321, 23);
            this.delay_progressBar.Step = 1;
            this.delay_progressBar.TabIndex = 2;
            this.delay_progressBar.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(467, 41);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(321, 23);
            this.progressBar2.Step = 1;
            this.progressBar2.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(361, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Delay Time:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(361, 41);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 128);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = "ms sleep time:";
            // 
            // ms_sleep_time_textBox
            // 
            this.ms_sleep_time_textBox.Location = new System.Drawing.Point(118, 128);
            this.ms_sleep_time_textBox.Name = "ms_sleep_time_textBox";
            this.ms_sleep_time_textBox.Size = new System.Drawing.Size(100, 23);
            this.ms_sleep_time_textBox.TabIndex = 7;
            this.ms_sleep_time_textBox.Text = "5";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(12, 70);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 23);
            this.textBox6.TabIndex = 8;
            this.textBox6.Text = "Iteraton Number";
            // 
            // iteration_number_textBox
            // 
            this.iteration_number_textBox.Location = new System.Drawing.Point(118, 70);
            this.iteration_number_textBox.Name = "iteration_number_textBox";
            this.iteration_number_textBox.Size = new System.Drawing.Size(100, 23);
            this.iteration_number_textBox.TabIndex = 9;
            this.iteration_number_textBox.Text = "10000";
            // 
            // scroll_step_textBox
            // 
            this.scroll_step_textBox.Location = new System.Drawing.Point(118, 99);
            this.scroll_step_textBox.Name = "scroll_step_textBox";
            this.scroll_step_textBox.Size = new System.Drawing.Size(100, 23);
            this.scroll_step_textBox.TabIndex = 12;
            this.scroll_step_textBox.Text = "-1";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(12, 99);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 23);
            this.textBox7.TabIndex = 11;
            this.textBox7.Text = "Scroll Step";
            // 
            // delay_ms_textBox
            // 
            this.delay_ms_textBox.Location = new System.Drawing.Point(118, 12);
            this.delay_ms_textBox.Name = "delay_ms_textBox";
            this.delay_ms_textBox.Size = new System.Drawing.Size(100, 23);
            this.delay_ms_textBox.TabIndex = 14;
            this.delay_ms_textBox.Text = "1500";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(12, 12);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 23);
            this.textBox8.TabIndex = 13;
            this.textBox8.Text = "Delay ms";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.delay_ms_textBox);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.scroll_step_textBox);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.iteration_number_textBox);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.ms_sleep_time_textBox);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.delay_progressBar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.scrool_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button scrool_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar delay_progressBar;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox ms_sleep_time_textBox;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox iteration_number_textBox;
        private System.Windows.Forms.TextBox scroll_step_textBox;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox delay_ms_textBox;
        private System.Windows.Forms.TextBox textBox8;
    }
}

