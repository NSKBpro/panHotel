using HotelManagment.Commands.ReservationCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HotelManagment.ViewModels
{
    class ReservationViewModel
    {
        ICommand newRoomServiceCommand;

        public ReservationViewModel()
        {
            new NewRoomServiceCommand(this);
        }


        public ICommand NewRoomServiceCommand
        {
            get
            {
                return newRoomServiceCommand;
            }
        }

        public void NewRoomService()
        {
           
        }
    }
}
