using HotelManagment.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HotelManagment.Commands.ReservationCommand
{
    class NewRoomServiceCommand : ICommand
    {
        ReservationViewModel _reservationViewModel;
        public NewRoomServiceCommand(ReservationViewModel reservationVM)
        {
            _reservationViewModel = reservationVM;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            _reservationViewModel.NewRoomService();
        }
    }
}
