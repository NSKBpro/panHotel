﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.ViewModels
{
    class ParentViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private object selectedItem;

        public ParentViewModel()
        {
            ClockViewModel = new ClockViewModel();
            MainApplicationViewModel = new MainApplicationViewModel();
            LoginViewModel = new LoginViewModel();
            RegistrationViewModel = new RegistrationViewModel();
            ReservationViewModel = new ReservationViewModel();
        }


        public ClockViewModel ClockViewModel { get; set; }
        public MainApplicationViewModel MainApplicationViewModel { get; set; }
        public LoginViewModel LoginViewModel { get; set; }
        public RegistrationViewModel RegistrationViewModel {get ;set;}
        public ReservationViewModel ReservationViewModel { get; set; }



        public object SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
                NotifyPropertyChanged("SelectedItem");
            }
        }

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
