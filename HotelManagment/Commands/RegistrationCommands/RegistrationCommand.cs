using HotelManagment.ViewModels;
using HotelService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace HotelManagment.Commands.RegistrationCommands
{
    class RegistrationCommand : ICommand
    {
        RegistrationViewModel _regViewModel;
        public RegistrationCommand(RegistrationViewModel registrationViewModel)
        {
            _regViewModel = registrationViewModel;
        }

        public bool CanExecute(object parameter)
        {
            if (parameter != null)
            {
                return true;
            }
            else
            {
                return false;
            }
          
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {

                var values = (object[])parameter;
                string username = ((TextBox)values[0]).Text;
                string password = ((PasswordBox)values[1]).Password;
                string password2 = ((PasswordBox)values[2]).Password;
                string name = ((TextBox)values[3]).Text;
                string surname = ((TextBox)values[4]).Text;
                string uniqueID = ((TextBox)values[5]).Text;
                string adress = ((TextBox)values[6]).Text;
                var panel = ((DockPanel)values[7]);
                string gendre = panel.Children.OfType<RadioButton>()
                 .FirstOrDefault(r => r.IsChecked.HasValue && r.IsChecked.Value).Content.ToString(); ;
                string dateBirth = ((DatePicker)values[8]).Text;
                DateTime dtFinal = DateTime.Parse(dateBirth);
                string state = ((TextBox)values[9]).Text;
                int postCode = Int32.Parse(((TextBox)values[10]).Text);
                string number = ((TextBox)values[11]).Text;
                string email = ((TextBox)values[12]).Text;
                if (password == password2)
                {
                    HotelUser ht = new HotelUser(username, password, name, surname, uniqueID, adress, gendre, dtFinal, email, state, number, postCode, "guest");
                    _regViewModel.UserRegistration(ht);
                }
                else
                {
                    _regViewModel.UserRegistration(null);
                }
               
        }
    }
}
