using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HotelService.Model;
namespace HotelService.Model
{
    public class MapperObjectClass
    {

        public static HotelRoom SwapRoom(Room databaseRoom){
          
           return new HotelRoom(databaseRoom.RoomId,
                                databaseRoom.RoomNumber,
                                databaseRoom.RoomType,
                                databaseRoom.RoomCapacity,
                                databaseRoom.RoomFloor,
                                databaseRoom.RoomOccupancy?true:false);
        }

        public static HotelRoomService SwapRoomService(RoomService databaseService)
        {
            return new HotelRoomService(databaseService.RoomServiceId,
                                        databaseService.Breakfast,
                                        databaseService.Lunch,
                                        databaseService.Dinner,
                                        databaseService.CleaningService,
                                        databaseService.SpecialService,
                                        databaseService.ServiceDone);
        }

        public static HotelUser SwapUser(User databaseUser)
        {
            return new HotelUser(databaseUser.UserId,
                                databaseUser.Username,
                                databaseUser.Password,
                                databaseUser.Name,
                                databaseUser.Surname,
                                databaseUser.UniqueID,
                                databaseUser.Adress,
                                databaseUser.Sex,
                                databaseUser.DateOfBird,
                                databaseUser.Email,
                                databaseUser.State,
                                databaseUser.Number,
                                databaseUser.PostCode,
                                databaseUser.Role);
        }

        public static User SwapHotelUser(HotelUser user)
        {
            User swapedUser = new User();

            swapedUser.Username = user.Username;
            swapedUser.Password = user.Password;
            swapedUser.Name = user.Name;
            swapedUser.Surname = user.Surname;
            swapedUser.Adress = user.Adress;
            swapedUser.UniqueID = user.UniqueID;
            swapedUser.Sex = user.Sex;
            swapedUser.DateOfBird = user.DateOfBird;
            swapedUser.Email = user.Email;
            swapedUser.State = user.State;
            swapedUser.Number = user.Number;
            swapedUser.PostCode = user.PostCode;
            swapedUser.Role = "guest";

            return swapedUser;
        }

        public static Room SwapHotelRoom(HotelRoom hotelRoom)
        {
            Room room = new Room();
            room.RoomId = hotelRoom.RoomId;
            room.RoomNumber = hotelRoom.RoomNumber;
            room.RoomOccupancy = hotelRoom.RoomOccupancy;
            room.RoomFloor = hotelRoom.RoomFloor;
            room.RoomCapacity = hotelRoom.RoomCapacity;
            room.RoomType = hotelRoom.RoomType;

            return room;
        }

        public static RoomService SwapRoomService(HotelRoomService hotelRoomService)
        {
            RoomService roomService = new RoomService();
            roomService.RoomServiceId = hotelRoomService.RoomServiceId;
            roomService.Breakfast = hotelRoomService.Breakfast;
            roomService.Lunch = hotelRoomService.Lunch;
            roomService.Dinner = hotelRoomService.Dinner;
            roomService.CleaningService = hotelRoomService.CleaningService;
            roomService.ServiceDone = hotelRoomService.ServiceDone;
            roomService.SpecialService = hotelRoomService.SpecialService;

            return roomService;


        }

        public static Reservation SwapHotelReservation(HotelReservation hotelReservation)
        {
            Reservation reservation = new Reservation();

            reservation.UserID = hotelReservation.User.UserId;
            reservation.RoomID = hotelReservation.Room.RoomId;
            reservation.RoomServiceID = hotelReservation.RoomService.RoomServiceId;
            reservation.ReservationId = hotelReservation.ReservationId;
            reservation.Price = hotelReservation.Price;
            reservation.DateCheckIN = hotelReservation.DateCheckIN;
            reservation.DateCheckOUT = hotelReservation.DateCheckOUT;


            return reservation;
        }
    }
}