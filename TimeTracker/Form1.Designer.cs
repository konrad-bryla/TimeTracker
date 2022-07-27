
namespace TimeTracker
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
            this.components = new System.ComponentModel.Container();
            this.Start = new System.Windows.Forms.Button();
            this.timerVisual = new System.Windows.Forms.TextBox();
            this.stop = new System.Windows.Forms.Button();
            this.pomodoro = new System.Windows.Forms.Button();
            this.shortBreak = new System.Windows.Forms.Button();
            this.longBreak15 = new System.Windows.Forms.Button();
            this.aTmr = new System.Windows.Forms.Timer(this.components);
            this.longbreak30 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(91, 67);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(136, 47);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.start_Click);
            // 
            // timerVisual
            // 
            this.timerVisual.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerVisual.Location = new System.Drawing.Point(69, 12);
            this.timerVisual.Name = "timerVisual";
            this.timerVisual.ReadOnly = true;
            this.timerVisual.Size = new System.Drawing.Size(180, 49);
            this.timerVisual.TabIndex = 3;
            this.timerVisual.Text = "0";
            this.timerVisual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(91, 120);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(136, 47);
            this.stop.TabIndex = 4;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // pomodoro
            // 
            this.pomodoro.Location = new System.Drawing.Point(91, 173);
            this.pomodoro.Name = "pomodoro";
            this.pomodoro.Size = new System.Drawing.Size(136, 23);
            this.pomodoro.TabIndex = 5;
            this.pomodoro.Text = "Pomodoro 25m";
            this.pomodoro.UseVisualStyleBackColor = true;
            this.pomodoro.Click += new System.EventHandler(this.pomodoro_Click);
            // 
            // shortBreak
            // 
            this.shortBreak.Location = new System.Drawing.Point(91, 202);
            this.shortBreak.Name = "shortBreak";
            this.shortBreak.Size = new System.Drawing.Size(136, 23);
            this.shortBreak.TabIndex = 6;
            this.shortBreak.Text = "Short Break 5m";
            this.shortBreak.UseVisualStyleBackColor = true;
            this.shortBreak.Click += new System.EventHandler(this.shortBreak_Click);
            // 
            // longBreak15
            // 
            this.longBreak15.Location = new System.Drawing.Point(91, 231);
            this.longBreak15.Name = "longBreak15";
            this.longBreak15.Size = new System.Drawing.Size(136, 23);
            this.longBreak15.TabIndex = 7;
            this.longBreak15.Text = "Long Break 15m";
            this.longBreak15.UseVisualStyleBackColor = true;
            this.longBreak15.Click += new System.EventHandler(this.longBreak15_Click);
            // 
            // aTmr
            // 
            this.aTmr.Enabled = true;
            this.aTmr.Interval = 1000;
            this.aTmr.Tick += new System.EventHandler(this.aTmr_Tick);
            // 
            // longbreak30
            // 
            this.longbreak30.Location = new System.Drawing.Point(91, 260);
            this.longbreak30.Name = "longbreak30";
            this.longbreak30.Size = new System.Drawing.Size(136, 23);
            this.longbreak30.TabIndex = 8;
            this.longbreak30.Text = "Long Break 30m";
            this.longbreak30.UseVisualStyleBackColor = true;
            this.longbreak30.Click += new System.EventHandler(this.longbreak30_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 302);
            this.Controls.Add(this.longbreak30);
            this.Controls.Add(this.longBreak15);
            this.Controls.Add(this.shortBreak);
            this.Controls.Add(this.pomodoro);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.timerVisual);
            this.Controls.Add(this.Start);
            this.Name = "Form1";
            this.Text = "Time Tracker ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox timerVisual;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button pomodoro;
        private System.Windows.Forms.Button shortBreak;
        private System.Windows.Forms.Button longBreak15;
        private System.Windows.Forms.Timer aTmr;
        private System.Windows.Forms.Button longbreak30;
    }
}

