using System;
using System.Windows.Forms;


namespace TimeTracker
{
    public partial class Form1 : Form
    {
        int time;
        public Form1()
        {
            InitializeComponent();
            aTmr.Stop();
        }

        private void start_Click(object sender, EventArgs e)
        {
            time = Convert.ToInt32(timerVisual.Text);
            aTmr.Start();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            aTmr.Stop();
        }

        private void aTmr_Tick(object sender, EventArgs e)
        {
            timerVisual.Text = time--.ToString();
            if(time < 0)
            {
                aTmr.Stop();
                MessageBox.Show("Your pomodoro time is up, take a break. No secret work!", "Time for a Break");
            }
        }

        private void pomodoro_Click(object sender, EventArgs e)
        {
            time = 1500;
            timerVisual.Text = "1500";
        }

        private void shortBreak_Click(object sender, EventArgs e)
        {
            time = 300;
            timerVisual.Text = "300";
        }

        private void longBreak15_Click(object sender, EventArgs e)
        {
            time = 900;
            timerVisual.Text = "900";
        }

        private void longbreak30_Click(object sender, EventArgs e)
        {
            time = 1800;
            timerVisual.Text = "1800";
        }
    }
}
