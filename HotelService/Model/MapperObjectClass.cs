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
    }
}