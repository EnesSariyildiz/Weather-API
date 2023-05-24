using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace weather
{
    internal class Program
    {

        static void Main(string[] args)
        {
            API api = new API
            {
                apiKey = "dbde231e68ae236f5dd1295bb01089f8",
                apiConnection = "http://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=dbde231e68ae236f5dd1295bb01089f8"
            };

            XDocument weather = XDocument.Load(api.apiConnection);

            var temp = weather.Descendants("temperature").ElementAt(0).Attribute("value").Value;

            var weatherState = weather.Descendants("weather").ElementAt(0).Attribute("value").Value;

            var cloudState = weather.Descendants("clouds").ElementAt(0).Attribute("value").Value;

            Console.WriteLine("İstanbul air temperature:" + " " + temp);

            Console.WriteLine("İstanbul weather:" + " " + weatherState);

            Console.WriteLine("İstanbul clouds:" + " " + cloudState);


            Console.ReadLine();
        }
    }
}
