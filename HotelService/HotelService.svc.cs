using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using HotelService.Model;
using System.Collections.ObjectModel;

namespace HotelService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class HotelService : HotelServisInterface
    {
        HotelManagmentSystemEntities db = new HotelManagmentSystemEntities();
        public ObservableCollection<HotelReservation> GetReservations()
        {
            ObservableCollection<HotelReservation> hotelReservations = new ObservableCollection<HotelReservation>();

            foreach(Reservation reservationFromDataBase in db.Reservation){
                HotelReservation hoterReservation = new HotelReservation(reservationFromDataBase.ReservationId,
                                                                         FindUserByID(reservationFromDataBase.UserID),
                                                                         FindRoomByID(reservationFromDataBase.RoomID),
                                                                         FindRoomServiceByID(reservationFromDataBase.RoomServiceID),
                                                                         reservationFromDataBase.DateCheckIN,
                                                                         reservationFromDataBase.DateCheckOUT,
                                                                         reservationFromDataBase.Price);
                hotelReservations.Add(hoterReservation);

            }
            return hotelReservations;
        }

        private HotelRoom FindRoomByID(int roomId)
        {
            foreach (Room roomDataBase in db.Room)
            {
                if (roomDataBase.RoomId == roomId)
                {
                    return MapperObjectClass.SwapRoom(roomDataBase);
                }
            }

            return null;
        }

        private HotelRoomService FindRoomServiceByID(int roomServiceId)
        {
            foreach (RoomService roomServiceBase in db.RoomService)
            {
                if (roomServiceBase.RoomServiceId == roomServiceId)
                {
                    return MapperObjectClass.SwapRoomService(roomServiceBase);
                }
            }

            return null;
        }

        private HotelUser FindUserByID(int userId)
        {
            foreach (User userBase in db.User)
            {
                if (userBase.UserId == userId)
                {
                    return MapperObjectClass.SwapUser(userBase);
                }
            }

            return null;
        }


        public ObservableCollection<HotelUser> ListHotelGuest()
        {
            ObservableCollection<HotelUser> hotelGuests = new ObservableCollection<HotelUser>();
            foreach (User userDatabase in db.User)
            {
                if (userDatabase.Role == "guest")
                {
                    hotelGuests.Add(MapperObjectClass.SwapUser(userDatabase));
                }
            }

            return hotelGuests;
        }


        public ObservableCollection<HotelRoom> ListHotelRooms()
        {
            ObservableCollection<HotelRoom> hotelRooms = new ObservableCollection<HotelRoom>();

            foreach (Room roomDatabase in db.Room)
            {
                if (roomDatabase.RoomOccupancy)
                {
                    hotelRooms.Add(MapperObjectClass.SwapRoom(roomDatabase));
                }
             
            }
            return hotelRooms;
        }




        public HotelUser CheckLoginUser(string username,string password)
        {
            foreach (User userDatabase in db.User)
            {
                if (userDatabase.Username.Trim() == username && userDatabase.Password.Trim() == password)
                {
                    return MapperObjectClass.SwapUser(userDatabase);
                }
            }
            return null;
        }




        public bool RegistrationUser(User userFromRegistration)
        {
            db.User.Add(userFromRegistration);
            db.SaveChanges();
            return true;
        }


        public bool DeleteReservation(Reservation reservationDelete)
        {
            db.Reservation.Attach(reservationDelete);
            db.Reservation.Remove(reservationDelete);
            db.SaveChanges();
            return true;
        }
    }
}
