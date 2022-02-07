
namespace GUI
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
            this.components = new System.ComponentModel.Container();
            this.ShutDown = new System.Windows.Forms.RadioButton();
            this.Restart = new System.Windows.Forms.RadioButton();
            this.Start = new System.Windows.Forms.Button();
            this.Hours = new System.Windows.Forms.TextBox();
            this.Minutes = new System.Windows.Forms.TextBox();
            this.Seconds = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Stop = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Timerlb = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShutDown
            // 
            this.ShutDown.AutoSize = true;
            this.ShutDown.Location = new System.Drawing.Point(202, 283);
            this.ShutDown.Name = "ShutDown";
            this.ShutDown.Size = new System.Drawing.Size(80, 19);
            this.ShutDown.TabIndex = 0;
            this.ShutDown.TabStop = true;
            this.ShutDown.Text = "ShutDown";
            this.ShutDown.UseVisualStyleBackColor = true;
            this.ShutDown.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Restart
            // 
            this.Restart.AutoSize = true;
            this.Restart.Location = new System.Drawing.Point(486, 283);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(61, 19);
            this.Restart.TabIndex = 1;
            this.Restart.TabStop = true;
            this.Restart.Text = "Restart";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(202, 341);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(128, 54);
            this.Start.TabIndex = 2;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.button1_Click);
            // 
            // Hours
            // 
            this.Hours.Location = new System.Drawing.Point(157, 230);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(100, 23);
            this.Hours.TabIndex = 4;
            // 
            // Minutes
            // 
            this.Minutes.Location = new System.Drawing.Point(320, 230);
            this.Minutes.Name = "Minutes";
            this.Minutes.Size = new System.Drawing.Size(100, 23);
            this.Minutes.TabIndex = 5;
            // 
            // Seconds
            // 
            this.Seconds.Location = new System.Drawing.Point(486, 230);
            this.Seconds.Name = "Seconds";
            this.Seconds.Size = new System.Drawing.Size(100, 23);
            this.Seconds.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Minutes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(486, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Seconds";
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(423, 341);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(124, 54);
            this.Stop.TabIndex = 11;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Timerlb);
            this.groupBox1.Location = new System.Drawing.Point(259, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 130);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Timer";
            // 
            // Timerlb
            // 
            this.Timerlb.AutoSize = true;
            this.Timerlb.Location = new System.Drawing.Point(79, 62);
            this.Timerlb.Name = "Timerlb";
            this.Timerlb.Size = new System.Drawing.Size(49, 15);
            this.Timerlb.TabIndex = 0;
            this.Timerlb.Text = "00:00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Seconds);
            this.Controls.Add(this.Minutes);
            this.Controls.Add(this.Hours);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.ShutDown);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton ShutDown;
        private System.Windows.Forms.RadioButton Restart;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox Hours;
        private System.Windows.Forms.TextBox Minutes;
        private System.Windows.Forms.TextBox Seconds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Timerlb;
    }
}

