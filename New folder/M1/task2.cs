using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Task2
{ 
    class Car
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public string Color { get; set; }
            public Car()
            {

            }
            public Car(string make, string model, int year, string color)
            {
                this.Make = make;
                this.Model = model;
                this.Year = year;
                this.Color = color;
            }
            public string Serialize(Car car)
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Car));
                using (StringWriter textWriter = new StringWriter())
                {
                    xmlSerializer.Serialize(textWriter, car);
                    return textWriter.ToString();
                }
            }
            public Car DeSerialize(string xmlPath)
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Car));
                StringReader stringReader;
                stringReader = new StringReader(xmlPath);
                XmlTextReader xmlReader;
                xmlReader = new XmlTextReader(stringReader);
                Car obj;
                obj = (Car)xmlSerializer.Deserialize(xmlReader);
                return obj;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Car carObj = new Car("Car", "ST", 2022, "Red");
                string msg = carObj.Serialize(carObj);
                Car desrObj = carObj.DeSerialize("<xml></xml>");
            }
        }
    }
