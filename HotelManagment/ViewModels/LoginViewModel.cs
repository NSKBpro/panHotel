﻿using HotelManagment.Commands.LoginCommands;
using HotelService.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace HotelManagment.ViewModels
{
    class LoginViewModel : INotifyPropertyChanged
    {

        HotelServiceFinal.HotelServisInterfaceClient hotelService = new HotelServiceFinal.HotelServisInterfaceClient();
         static  HotelUser loginUser;
        ICommand loginCommand;
        string username, password;

        public LoginViewModel()
        {
            loginCommand = new LoginCommand(this);
        }


        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
                NotifyPropertyChanged("Username");
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
                NotifyPropertyChanged("Password");
            }
        }

       public ICommand LoginCommand
        {
            get
            {
                return loginCommand;
            }
        }

       public HotelUser UserLogin
       {
           get
           {
               return loginUser;
           }

           set
           {
               loginUser = value;
               NotifyPropertyChanged("UserLogin");
           }
       }


        public bool LoginUser(string username,string password)
        {
            UserLogin = hotelService.CheckLoginUser(username, password);
            if (UserLogin != null)
            {
               
                MainWindow mw = new MainWindow();
                mw.Show();
                Application.Current.MainWindow.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Wrong login!");
                return false;
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
