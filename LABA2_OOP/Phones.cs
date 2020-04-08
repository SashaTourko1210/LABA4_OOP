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
    class Phones
    {
        [DataMember]
        public string Name
        {
            get; set;
        }
        [DataMember]
        public DateTime RepairStartDate
        {
            get; set;
        }
        [DataMember]
        public string Number
        {
            get; set;
        }
        [DataMember]
        public double EstimatedCost
        {
            get; set;
        }
        [DataMember]
        public Address Address
        {
            get; set;
        }

        public Phones() { }
        public Phones(string name, DateTime repairStartDate, string number, Address address, double estimatedCost)
        {
            Name = name;
            RepairStartDate = repairStartDate;
            Number = number;
            Address = address;
            EstimatedCost = estimatedCost;
        }
    }
}

