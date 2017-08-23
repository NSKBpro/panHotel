using HotelManagment.ViewModels;
using HotelService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace HotelManagment.Commands.LoginCommands
{
    class RegistrationCommand : ICommand
    {

        private LoginViewModel _loginViewModel;

        public RegistrationCommand(LoginViewModel mainView)
        {
            _loginViewModel = mainView;
        }


        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
           
            _loginViewModel.RegistrationUser();
          
        }
    }
}
