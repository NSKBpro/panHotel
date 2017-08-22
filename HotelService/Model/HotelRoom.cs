using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace HotelService.Model
{
    [DataContract]
    public class HotelRoom
    {
        [DataMember]
        public int RoomId { get; set; }
        [DataMember]
        public int RoomNumber { get; set; }
        [DataMember]
        public string RoomType { get; set; }
        [DataMember]
        public int RoomCapacity { get; set; }
        [DataMember]
        public int RoomFloor { get; set; }
        [DataMember]
        public bool RoomOccupancy { get; set; }
      

        public HotelRoom(int roomId,int roomNumber,string roomType,int roomCapacity,int roomFloor,bool roomOccupancy)
        {
            this.RoomId = roomId;
            this.RoomNumber = roomNumber;
            this.RoomType = roomType;
            this.RoomCapacity = roomCapacity;
            this.RoomFloor = roomFloor;
            this.RoomOccupancy = RoomOccupancy;
        }

        public HotelRoom()
        {

        }
    }
}