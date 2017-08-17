using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace HotelManagment.ViewModels
{
    public class ClockViewModel : INotifyPropertyChanged
    {
        public ClockViewModel()
        {
            var timer = new Timer();
            timer.Interval = 500; 
            timer.Elapsed += TimerElapsed;
            timer.Start();
        }

        public string Time
        {
            get { return DateTime.Now.ToLongTimeString(); }
        }
        public string Date
        {
            get { return DateTime.Now.ToString("dddd, dd MMM yyyy"); }
        }

        void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            NotifyPropertyChanged("Time");
            NotifyPropertyChanged("Date");
        }

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
