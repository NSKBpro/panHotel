﻿



using HotelService;
using HotelService.Model;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
namespace HotelManagment.ViewModels
{
    class MainApplicationViewModel : INotifyPropertyChanged
    {

     
        HotelServiceFinal.HotelServisInterfaceClient hotelService = new HotelServiceFinal.HotelServisInterfaceClient();

        ObservableCollection<HotelReservation> listOfReservations;
        ObservableCollection<HotelUser> listOfUsers;
        ObservableCollection<HotelRoom> listOfRooms;

        HotelReservation reservation = new HotelReservation();
        HotelUser cmbHotelUser = new HotelUser();
        HotelRoom cmbHotelRoom = new HotelRoom();
       
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

        public ObservableCollection<HotelUser> ListGuests
        {
            get
            {
                listOfUsers = new ObservableCollection<HotelUser>(hotelService.ListHotelGuest());
                return listOfUsers;

            }
            set
            {
                listOfUsers = value;
                NotifyPropertyChanged("ListGuests");
            }
        }

        public HotelUser SelectedHotelUser 
        {
            get
            {
                return cmbHotelUser;
            }
            set
            {
                cmbHotelUser = value;
                NotifyPropertyChanged("SelectedHotelUser");
            }
        }

        public ObservableCollection<HotelRoom> ListHotelRooms
        {
            get
            {
                listOfRooms = new ObservableCollection<HotelRoom>(hotelService.ListHotelRooms());
                return listOfRooms;
            }
            set
            {
                listOfRooms = value;
                NotifyPropertyChanged("ListHotelRooms");
            }
        }

        public HotelRoom SelectedHotelRoom
        {
            get
            {
                return cmbHotelRoom;
            }
            set
            {
                cmbHotelRoom = value;
                NotifyPropertyChanged("SelectedHotelRoom");
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
