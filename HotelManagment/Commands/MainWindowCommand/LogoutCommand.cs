using HotelManagment.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HotelManagment.Commands.MainWindowCommand
{
    class LogoutCommand : ICommand
    {
        MainApplicationViewModel _mainViewModel;

        public LogoutCommand(MainApplicationViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            _mainViewModel.LogoutUser();
        }
    }
}
