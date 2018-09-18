using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfHotels
{
    [DataContract]
    public class HotelDemo
    {
        [DataMember]
        public string Id;
        [DataMember]
        public string Name;
        [DataMember]
        public string Address;
        [DataMember]
        public string Ratings;
    }
    [ServiceContract]
    public interface IHotels
    {
        [OperationContract]
        List<HotelDemo> GetAllHotels();
        [OperationContract]
        HotelDemo GetById(string id);
    }

    public class GetHotels : IHotels
    {
        public List<HotelDemo> GetAllHotels()
        {
            string filepath = "C:/Users/pvashisht/source/repos/WcfHotels/Hotels.json";
            string result = string.Empty;
            List<HotelDemo> HotelList = new List<HotelDemo>();
            using (StreamReader r = new StreamReader(filepath))
            {
                var json = r.ReadToEnd();
                HotelList = JsonConvert.DeserializeObject<List<HotelDemo>>(json);
                return HotelList;
            }

        }

        public HotelDemo GetById(string id)
        {
            List<HotelDemo> hlist = new List<HotelDemo>(GetAllHotels());

            foreach (var hotel in hlist)
            {
                if (hotel.Id == id)
                {
                    return hotel;
                }
            }
            return null;
        }


    }
}
