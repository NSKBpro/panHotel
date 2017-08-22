using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace HotelService.Model
{
    [DataContract]
    public class HotelReservation
    {
        [DataMember]
        public int ReservationId { get; set; }
        [DataMember]
        public HotelUser User { get; set; }
        [DataMember]
        public HotelRoom Room { get; set; }
        [DataMember]
        public HotelRoomService RoomService { get; set; }
        [DataMember]
        public System.DateTime DateCheckIN { get; set; }
        [DataMember]
        public System.DateTime DateCheckOUT { get; set; }
        [DataMember]
        public float Price { get; set; }

        public HotelReservation(int reservationId,HotelUser user,HotelRoom room,HotelRoomService service,DateTime checkIn,DateTime checkOut,float price)
        {
            this.ReservationId = reservationId;
            this.User = user;
            this.Room = room;
            this.RoomService = service;
            this.DateCheckIN = checkIn;
            this.DateCheckOUT = checkOut;
            this.Price = price;
        }

        public HotelReservation()
        {

        }
    }
}