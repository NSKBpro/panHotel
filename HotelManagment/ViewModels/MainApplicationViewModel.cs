



using HotelService;
using HotelService.Model;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
namespace HotelManagment.ViewModels
{
    class MainApplicationViewModel : INotifyPropertyChanged
    {

        HotelReservation reservation = new HotelReservation();
        HotelServiceFinal.HotelServisInterfaceClient hotelService = new HotelServiceFinal.HotelServisInterfaceClient();

        ObservableCollection<HotelReservation> listOfReservations;
       
        public HotelReservation SelectedReservation
        {
            get
            {
                return reservation;
            }
            set
            {
                reservation = value;
                NotifyPropertyChanged("SelectedReservation");
            }   
        }

        public ObservableCollection<HotelReservation> LoadReservations
        {
            get 
            {
                listOfReservations = new ObservableCollection<HotelReservation>(hotelService.GetReservations());
                return listOfReservations;
            }

            set
            { 
                listOfReservations = value;
                NotifyPropertyChanged("LoadReservations");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
