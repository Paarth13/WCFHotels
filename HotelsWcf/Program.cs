using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using HotelsWcf.ServiceReference1;
using Newtonsoft.Json;

namespace HotelsWcf
{
    class Program
    {
        static void Main(string[] args)
        {
            HotelsClient hc = new HotelsClient("BasicHttpBinding_IHotels");
            List<HotelDemo> HotelList = new List<HotelDemo>(hc.GetAllHotels());
            foreach (var hotel in HotelList)
            {

                Console.WriteLine("Id {0}", hotel.Id);
                Console.WriteLine("Name {0}", hotel.Name);
                Console.WriteLine("Address {0}", hotel.Address);
                Console.WriteLine("Ratings {0}", hotel.Ratings);

            }

            Console.WriteLine("Enter an id you want to select");
            string id = Console.ReadLine();
            HotelDemo hotels = hc.GetById(id);
            Console.WriteLine("Id {0}", hotels.Id);
            Console.WriteLine("Name {0}", hotels.Name);
            Console.WriteLine("Address {0}", hotels.Address);
            Console.WriteLine("Ratings {0}", hotels.Ratings);



            Console.ReadKey();

        }
    }
}
