using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace stop_Watch
{
    public partial class Watcher : ContentPage
    {       
        public int seconds;
        public bool runing = false;
        public Watcher()
        {
            InitializeComponent();
        }


        private void Start_Clicked(object sender, EventArgs e)
        {
            if (!runing) { 
                RunTimer();
            }
        }

        private void Pause_Clicked(object sender, EventArgs e)
        {

           runing = false;
        }

        private void Reset_Clicked(object sender, EventArgs e)
        {
            runing = false;
            seconds = 0;
            lbTime.Text = string.Format("0:00:00");
        }


        public void RunTimer()
        {
            runing = true;
            Device.StartTimer(TimeSpan.FromSeconds(1), OnRuning);
        }


        public bool OnRuning()
        {
           
            if (runing)
            {
                int secon = seconds % 60;
                int minutes = seconds / 60;
                int hours = minutes / 60;
                
                lbTime.Text = string.Format("{0:d}:{1:d2}:{2:D2}", hours, minutes, secon);
                seconds++;
            }
            return  runing;
        }
  

       
    }
   
}
