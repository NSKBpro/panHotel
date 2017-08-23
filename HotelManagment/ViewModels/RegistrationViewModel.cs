using HotelManagment.Commands.RegistrationCommands;
using HotelManagment.Views;
using HotelService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace HotelManagment.ViewModels
{
    class RegistrationViewModel
    {
        HotelServiceFinal.HotelServisInterfaceClient hotelService = new HotelServiceFinal.HotelServisInterfaceClient();
        ICommand registrationCommand;

        public RegistrationViewModel()
        {
            registrationCommand = new RegistrationCommand(this);
        }

        public ICommand RegistrationUserCommand
        {
            get
            {
                return registrationCommand;
            }
        }

        public void UserRegistration(HotelUser userFromRegistration)
        {
            if (userFromRegistration != null)
            {
                if (hotelService.RegistrationUser(MapperObjectClass.SwapHotelUser(userFromRegistration)))
                {

                    Login loginWindow = new Login();
                    loginWindow.Show();
                    Application.Current.Windows[0].Close();


                    //Sending email - working 100%
                   /* MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    mail.From = new MailAddress("hotelmanagment101@gmail.com");
                    mail.To.Add(userFromRegistration.Email);
                    mail.Subject = "Test Mail";
                    mail.Body = String.Format("Zdravo {0} ovo su vasi podaci USERNAME: {1} PASSWORD: {2}", userFromRegistration.Name, userFromRegistration.Username, userFromRegistration.Password);

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("hotelmanagment101@gmail.com", "HOTEL101");
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);*/
                    //MessageBox.Show("mail Send");
                }
                else
                {
                    MessageBox.Show("Registration not complete successfully!");
                }
            }
            else
            {
                MessageBox.Show("Registration not complete successfully!");
            }
           
        }
    }
}
