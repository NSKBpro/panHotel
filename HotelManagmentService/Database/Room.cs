//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelManagmentService.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Room
    {
        public Room()
        {
            this.Reservation = new HashSet<Reservation>();
        }
    
        public int RoomId { get; set; }
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }
        public int RoomCapacity { get; set; }
        public int RoomFloor { get; set; }
        public bool RoomOccupancy { get; set; }
    
        public virtual ICollection<Reservation> Reservation { get; set; }
    }
}
