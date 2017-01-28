using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml.

namespace Reservation_Library
{
    public class FlightFactory
    {
        private List<Flights> flightList;
        private const string FILE_PATH =address";
        public void CreateFlightList()
        {

        }

        void SerializeFlightList()//Writes to XML Flight file
        {
            StreamWriter wr = new StreamWriter("Flights.xml");
            XmlSerializer serial = new XmlSerializer(flightList.GetType());
            serial.Serialize(wr, flightList);
            wr.Close();
        }

        void DeserializeFlightList()//Read from the XML Flight file
        {
            StreamReader rd = new StreamReader(FILE_PATH);
            XmlSerializer serial = new XmlSerializer(flightList.GetType());
            serial.Serialize(rd, flightList);
            rd.Close();
        }
    }
}
