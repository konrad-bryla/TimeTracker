/*aTmr was drag and droped from the vs toolbox onto the windows form (timer tool)
 * uses this documentation: https://docs.microsoft.com/en-us/dotnet/api/system.timers.timer?view=net-6.0 
*/
using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace TimeTracker
{
    public partial class Form1 : Form
    {
        int time;
        bool onBreak;
        SoundPlayer sPlayer = new SoundPlayer(Properties.Resources.shortAudio);
        public Form1()
        {
            InitializeComponent();
            aTmr.Stop();
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (time != 0) {
                aTmr.Start();
            } 
        }

        private void stop_Click(object sender, EventArgs e)
        {
            aTmr.Stop();
        }

        private void aTmr_Tick(object sender, EventArgs e)
        {
            timerVisual.Text = time--.ToString();
            if(time < 0 && onBreak == true)
            {
                aTmr.Stop();
                onBreak = false;
                sPlayer.Play();
                MessageBox.Show("Hey your break is up! Lets get some good work in! ", "Time for some work");
                
            }
            else if(time < 0)
            {
                onBreak = true;
                sPlayer.Play();
                MessageBox.Show("Your pomodoro time is up, take a break. No secret work!", "Time for a Break");
            }
        }

        private void pomodoro_Click(object sender, EventArgs e)
        {
            aTmr.Stop();
            time = 1500;
            timerVisual.Text = "1500";
        }

        private void shortBreak_Click(object sender, EventArgs e)
        {
            aTmr.Stop();
            time = 1;
            timerVisual.Text = "1";
            onBreak = true;
        }

        private void longBreak15_Click(object sender, EventArgs e)
        {
            aTmr.Stop();
            time = 900;
            timerVisual.Text = "900";
            onBreak = true;
        }

        private void longbreak30_Click(object sender, EventArgs e)
        {
            aTmr.Stop();
            time = 1800;
            timerVisual.Text = "1800";
            onBreak = true;
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            aTmr.Stop();
            time = 0;
            timerVisual.Text = "0";
            
        }
    }
}
