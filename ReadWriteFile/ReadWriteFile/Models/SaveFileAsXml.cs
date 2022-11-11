using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Xml.Serialization;

namespace ReadWriteFile.Models
{
    /// <summary>
    /// https://xmltocsharp.azurewebsites.net/
    /// </summary>

    [XmlRoot(ElementName = "address")]
    public class Address
    {
        [XmlElement(ElementName = "street")]
        public string Street { get; set; }
        [XmlElement(ElementName = "city")]
        public string City { get; set; }
        [XmlElement(ElementName = "state")]
        public string State { get; set; }
        [XmlElement(ElementName = "zip")]
        public string Zip { get; set; }
    }

    [XmlRoot(ElementName = "customer")]
    public class Customer
    {
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "address")]
        public List<Address> Address { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
    }

    [XmlRoot(ElementName = "customers")]
    public class Customers
    {
        [XmlElement(ElementName = "customer")]
        public Customer Customer { get; set; }
    }





    public class ReadXmlToObject
    {
        string Path;
        public Customers customers;
        public ReadXmlToObject(string Path)
        {
            this.Path = Path;
        }


        public void Read()
        {
            XmlSerializer serializer =
        new XmlSerializer(typeof(Customers));
            using (Stream reader = new FileStream(Path, FileMode.Open))
            {
                // Call the Deserialize method to restore the object's state.
                customers = (Customers)serializer.Deserialize(reader);
            }
        }
    }





    public class SaveFileAsXml : SaveFile
    {
        Customers customers;
        public SaveFileAsXml(string Path, Customers customers) : base(Path)
        {
            this.customers = customers;
        }

        public override bool Save()
        {
            try
            {
                System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(Customers));
                System.IO.FileStream file = System.IO.File.Create(Path);
                writer.Serialize(file, customers);
                file.Close();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
           

        }


    }

}
