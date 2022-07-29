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
        int time = 0;
        TimeSpan ts;
        bool onBreak;
        SoundPlayer sPlayer = new SoundPlayer(Properties.Resources.shortAudio);

        //Stops the timer at load so it does not automatically start counting down from 0
        public Form1()
        {
            InitializeComponent();
            aTmr.Stop();
        }
        
        //Starts the timer
        private void start_Click(object sender, EventArgs e)
        {
            if (time != 0) {
                aTmr.Start();
            } 
        }

        //Stops the timer
        private void stop_Click(object sender, EventArgs e)
        {
            aTmr.Stop();
        }

        //Called after every tick. Time is decreased by 1 and the timer visual is updated
        //if statement validated if the last timer was part of a break or a work period
        // two different message boxes are showed depending on if onBreak is true or false
        private void aTmr_Tick(object sender, EventArgs e)
        {
            time--;
            timerVisual.Text = tsString(ts, time);
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

        //Creates a 25 minute pomodoro work period
        private void pomodoro_Click(object sender, EventArgs e)
        {
            aTmr.Stop();
            time = 1500;
            timerVisual.Text = tsString(ts, time);
        }

        //Creates a 5 minute break
        private void shortBreak_Click(object sender, EventArgs e)
        {
            aTmr.Stop();
            time = 300;
            timerVisual.Text = tsString(ts, time);
            onBreak = true;
        }

        //Creates a 15 minute break
        private void longBreak15_Click(object sender, EventArgs e)
        {
            aTmr.Stop();
            time = 900;
            timerVisual.Text = tsString(ts, time);
            onBreak = true;
        }

        //Creates a 30 minute break
        private void longbreak30_Click(object sender, EventArgs e)
        {
            aTmr.Stop();
            time = 1800;
            timerVisual.Text = tsString(ts, time);
            onBreak = true;
        }

        //Skips the time only, onBreak is not changed
        private void btnSkip_Click(object sender, EventArgs e)
        {
            aTmr.Stop();
            time = 0;
            timerVisual.Text = "0";   
        }

        //converts time into "Minute:Seconds" using a TimeSpan 
        private static string tsString (TimeSpan ts, int time)
        {
            ts = TimeSpan.FromSeconds(time);

            return ts.ToString(@"mm\:ss");
        }
    }
}
