using HotelManagment.ViewModels;
using HotelService;
using HotelService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HotelManagment.Commands.MainWindowCommand
{
    class DeleteCommand : ICommand
    {
        private MainApplicationViewModel _mainApplicationVM;

        public DeleteCommand(MainApplicationViewModel mainVM)
        {
            _mainApplicationVM = mainVM;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            HotelReservation reservationDelete = (HotelReservation)parameter;
            _mainApplicationVM.DeleteReservation(reservationDelete);
        }
    }
}
