using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace HotelService.Model
{
    [DataContract]
    public class HotelUser
    {
        [DataMember]
        public int UserId { get; set; }
        [DataMember]
        public string Username { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Surname { get; set; }
        [DataMember]
        public string UniqueID { get; set; }
        [DataMember]
        public string Adress { get; set; }
        [DataMember]
        public string Sex { get; set; }
        [DataMember]
        public System.DateTime DateOfBird { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string State { get; set; }
        [DataMember]
        public string Number { get; set; }
        [DataMember]
        public int PostCode { get; set; }
        [DataMember]
        public string Role { get; set; }

        public HotelUser(int userId,string username,string password,string name,string surname,string uniqueID,string adress,string sex,
            DateTime dateOfBird,string email,string state,string number, int postCode, string role)
        {
            this.UserId = userId;
            this.Username = username;
            this.Password = password;
            this.Name = name;
            this.Surname = surname;
            this.UniqueID = uniqueID;
            this.Adress = adress;
            this.Sex = sex;
            this.DateOfBird = dateOfBird;
            this.Email = email;
            this.State = state;
            this.Number = number;
            this.PostCode = postCode;
            this.Role = role;
        }

        public HotelUser()
        {

        }
    }
}
