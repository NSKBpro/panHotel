using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace HotelService.Model
{
    [DataContract]
    public class HotelRoomService
    {
        [DataMember]
        public int RoomServiceId { get; set; }
        [DataMember]
        public bool Breakfast { get; set; }
        [DataMember]
        public bool Lunch { get; set; }
        [DataMember]
        public bool Dinner { get; set; }
        [DataMember]
        public bool CleaningService { get; set; }
        [DataMember]
        public bool SpecialService { get; set; }
        [DataMember]
        public bool ServiceDone { get; set; }

        public HotelRoomService(int roomServiceId,bool breakfast,bool lunch,bool dinner,bool cleaningService,bool specialService,
            bool serviceDone)
        {
            this.RoomServiceId = RoomServiceId;
            this.Breakfast = breakfast;
            this.Lunch = lunch;
            this.Dinner = dinner;
            this.CleaningService = cleaningService;
            this.SpecialService = specialService;
            this.ServiceDone = serviceDone;
        }
    }
}