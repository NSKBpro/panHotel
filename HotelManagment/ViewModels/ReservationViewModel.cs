using HotelManagment.Commands.ReservationCommand;
using HotelService.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HotelManagment.ViewModels
{
    class ReservationViewModel : INotifyPropertyChanged
    {
       
        HotelServiceFinal.HotelServisInterfaceClient hotelService = new HotelServiceFinal.HotelServisInterfaceClient();


        HotelRoom hotelRoom = new HotelRoom();
        HotelUser hotelUser = new HotelUser();

        ObservableCollection<HotelUser> listOfGuests;
        ObservableCollection<HotelRoom> listOfRooms;

        bool _breakfastChecked;
        bool _lunchChecked;
        bool _dinnerChecked;
        bool _specialServicesChecked;
        bool _cleaningServicesChecked;

        public ReservationViewModel()
        {
            listOfGuests = new ObservableCollection<HotelUser>(hotelService.ListHotelGuest());
            listOfRooms = new ObservableCollection<HotelRoom>(hotelService.ListHotelRooms());
        }


        public ObservableCollection<HotelRoom> FreeRooms
        {
            get
            {
                return listOfRooms;
            }
            set
            {
                listOfRooms = value;
                NotifyPropertyChanged("FreeRooms");
            }
        }

        public ObservableCollection<HotelUser> GuestsInBase
        {
            get
            {
                return listOfGuests;
            }
            set
            {
                listOfGuests = value;
                NotifyPropertyChanged("GuestsInBase");
            }
        }


        public HotelRoom FreeHotelRoom
        {
            get
            {
                return hotelRoom;
            }

            set
            {
                hotelRoom = value;
                NotifyPropertyChanged("FreeHotelRoom");
            }
        }
        public HotelUser SelectedHotelUser
        {
            get
            {
                return hotelUser;
            }

            set
            {
                hotelUser = value;
                NotifyPropertyChanged("SelectedHotelUser");
                NotifyPropertyChanged("SelectedGendreMale");
                NotifyPropertyChanged("SelectedGendreFemale");
            }
        }

        public bool SelectedGendreMale
        {
            
            get
            {
                if (SelectedHotelUser.Sex == "Male")
                {
                    return true;
                }
                return false;
               
            }

            set
            {
                SelectedHotelUser.Sex = "Male";
                NotifyPropertyChanged("SelectedGendreMale");
            }
        }
        public bool SelectedGendreFemale
        {

            get
            {
                if (SelectedHotelUser.Sex == "Female")
                {
                    return true;
                }
                return false;
            }

            set
            {
                SelectedHotelUser.Sex = "Female";
                NotifyPropertyChanged("SelectedGendreFemale");
            }
        }

        public bool BreakfastChecked
        {
            get
            {
                return _breakfastChecked;
            }
            set
            {
                if (_breakfastChecked == value) return;

                _breakfastChecked = value;
            }
        }

        public bool LunchChecked
        {
            get
            {
                return _lunchChecked;
            }
            set
            {
                if (_lunchChecked == value) return;

                _lunchChecked = value;
            }
        }

        public bool DinnerChecked
        {
            get
            {
                return _dinnerChecked;
            }
            set
            {
                if (_dinnerChecked == value) return;

                _dinnerChecked = value;
            }
        }

        public bool CleaningServiceChecked
        {
            get
            {
                return _cleaningServicesChecked;
            }
            set
            {
                if (_cleaningServicesChecked == value) return;

                _cleaningServicesChecked = value;
            }
        }

        public bool SpecialServiceChecked
        {
            get
            {
                return _specialServicesChecked;
            }
            set
            {
                if (_specialServicesChecked == value) return;

                _specialServicesChecked = value;
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
