using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace LABA2_OOP
{
    [Serializable]
    [DataContract]
    class Address
    {
        [DataMember]
        public string City
        {
            get; set;
        }
        [DataMember]
        public string Street
        {
            get; set;
        }
        [DataMember]
        public int Building
        {
            get; set;
        }
        public Address(string city, string street, int building)
        {
            City = city;
            Street = street;
            Building = building;
        }
    }
}
