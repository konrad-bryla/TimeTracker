
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
            this.btnSkip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Start.AutoSize = true;
            this.Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Start.ForeColor = System.Drawing.SystemColors.Window;
            this.Start.Location = new System.Drawing.Point(19, 115);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(136, 47);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.start_Click);
            // 
            // timerVisual
            // 
            this.timerVisual.BackColor = System.Drawing.Color.MidnightBlue;
            this.timerVisual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timerVisual.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.timerVisual.ForeColor = System.Drawing.SystemColors.Window;
            this.timerVisual.Location = new System.Drawing.Point(72, 30);
            this.timerVisual.Name = "timerVisual";
            this.timerVisual.ReadOnly = true;
            this.timerVisual.Size = new System.Drawing.Size(180, 46);
            this.timerVisual.TabIndex = 3;
            this.timerVisual.Text = "00:00";
            this.timerVisual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // stop
            // 
            this.stop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stop.AutoSize = true;
            this.stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stop.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.stop.ForeColor = System.Drawing.SystemColors.Window;
            this.stop.Location = new System.Drawing.Point(171, 115);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(135, 47);
            this.stop.TabIndex = 4;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // pomodoro
            // 
            this.pomodoro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pomodoro.AutoSize = true;
            this.pomodoro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pomodoro.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.pomodoro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.pomodoro.ForeColor = System.Drawing.SystemColors.Window;
            this.pomodoro.Location = new System.Drawing.Point(72, 209);
            this.pomodoro.Name = "pomodoro";
            this.pomodoro.Size = new System.Drawing.Size(186, 35);
            this.pomodoro.TabIndex = 5;
            this.pomodoro.Text = "Pomodoro 25m";
            this.pomodoro.UseVisualStyleBackColor = true;
            this.pomodoro.Click += new System.EventHandler(this.pomodoro_Click);
            // 
            // shortBreak
            // 
            this.shortBreak.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.shortBreak.AutoSize = true;
            this.shortBreak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shortBreak.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.shortBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.shortBreak.ForeColor = System.Drawing.SystemColors.Window;
            this.shortBreak.Location = new System.Drawing.Point(72, 250);
            this.shortBreak.Name = "shortBreak";
            this.shortBreak.Size = new System.Drawing.Size(186, 35);
            this.shortBreak.TabIndex = 6;
            this.shortBreak.Text = "Short Break 5m";
            this.shortBreak.UseVisualStyleBackColor = true;
            this.shortBreak.Click += new System.EventHandler(this.shortBreak_Click);
            // 
            // longBreak15
            // 
            this.longBreak15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.longBreak15.AutoSize = true;
            this.longBreak15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.longBreak15.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.longBreak15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.longBreak15.ForeColor = System.Drawing.SystemColors.Window;
            this.longBreak15.Location = new System.Drawing.Point(72, 291);
            this.longBreak15.Name = "longBreak15";
            this.longBreak15.Size = new System.Drawing.Size(186, 35);
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
            this.longbreak30.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.longbreak30.AutoSize = true;
            this.longbreak30.Cursor = System.Windows.Forms.Cursors.Hand;
            this.longbreak30.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.longbreak30.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.longbreak30.ForeColor = System.Drawing.SystemColors.Window;
            this.longbreak30.Location = new System.Drawing.Point(72, 332);
            this.longbreak30.Name = "longbreak30";
            this.longbreak30.Size = new System.Drawing.Size(186, 35);
            this.longbreak30.TabIndex = 8;
            this.longbreak30.Text = "Long Break 30m";
            this.longbreak30.UseVisualStyleBackColor = true;
            this.longbreak30.Click += new System.EventHandler(this.longbreak30_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSkip.AutoSize = true;
            this.btnSkip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSkip.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSkip.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnSkip.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSkip.Location = new System.Drawing.Point(98, 168);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(136, 35);
            this.btnSkip.TabIndex = 9;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(324, 414);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.longbreak30);
            this.Controls.Add(this.longBreak15);
            this.Controls.Add(this.shortBreak);
            this.Controls.Add(this.pomodoro);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.timerVisual);
            this.Controls.Add(this.Start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
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
        private System.Windows.Forms.Button btnSkip;
    }
}

