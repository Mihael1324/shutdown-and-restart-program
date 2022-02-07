using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace GUI
{
    public partial class Form1 : Form
    {

        TimeSpan timeLeft;

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckTexBoxValues();
            bool isStartable = true;

            try
            {
                timeLeft = new TimeSpan(Convert.ToInt32(Hours.Text), Convert.ToInt32(Minutes.Text), Convert.ToInt32(Seconds.Text));
            }
            catch(FormatException ex)
            {
                isStartable = false;
                MessageBox.Show(ex.Message,"Error");
            }

            if(isStartable == true)
            {
                Timer.Start();
                Timerlb.Text = timeLeft.ToString(@"hh\:mm\:ss");
            }
            
        }

        private void CheckTexBoxValues()
        {
            if(Hours.Text.Count() == 0)
            {
                Hours.Text = "0";
            }
            if (Minutes.Text.Count() == 0)
            {
                Minutes.Text = "0";
            }
            if (Seconds.Text.Count() == 0)
            {
                Seconds.Text = "0";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timeLeft = timeLeft.Subtract(TimeSpan.FromSeconds(1));
            Timerlb.Text = timeLeft.ToString(@"hh\:mm\:ss");

            if(timeLeft.TotalSeconds <= 0)
            {
                Timer.Stop();
                PerformAction();
            }
        }

        private void PerformAction()
        {
            if (ShutDown.Checked == true)
            {
                //Process.Start("shutdown", "/s");
                MessageBox.Show("shutdown");
            }
            else if(Restart.Checked == true)
            {
                //Process.Start("shutdown", "/r");
                MessageBox.Show("restart");
            } 
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            Timerlb.Text = "00:00:00";
        }
    }
}
