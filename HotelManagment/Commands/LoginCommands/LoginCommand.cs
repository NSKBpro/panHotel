using HotelManagment.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace HotelManagment.Commands.LoginCommands
{
    class LoginCommand : ICommand
    {
        private LoginViewModel _loginViewModel;

        public LoginCommand(LoginViewModel mainView)
        {
            _loginViewModel = mainView;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        

        public void Execute(object parameter)
        {
            var values = (object[])parameter;
            var username = ((TextBox)values[0]).Text;
            var password = ((PasswordBox)values[1]).Password;
            _loginViewModel.LoginUser(username,password);
        }
        public event EventHandler CanExecuteChanged;
    }
}
