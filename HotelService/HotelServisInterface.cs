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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface HotelServisInterface
    {

        [OperationContract]
        ObservableCollection<HotelReservation> GetReservations();
        [OperationContract]
        ObservableCollection<HotelUser> ListHotelGuest();
        [OperationContract]
        ObservableCollection<HotelRoom> ListHotelRooms();

        [OperationContract]
        HotelUser CheckLoginUser(string username,string password);
    }


}
