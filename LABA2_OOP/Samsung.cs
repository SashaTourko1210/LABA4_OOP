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
    class Samsung : Phones
    {
        [DataMember]
        public String PhoneModel
        {
            get; set;
        }

        [DataMember]
        public bool Restored
        {
            get; set;
        }

        public Samsung(string name, DateTime repairStartDate, string number, Address address, double estimatedCost,
            bool restored, string phonemodel) : base(name, repairStartDate, number, address, estimatedCost)
        {
            PhoneModel = phonemodel;
            Restored = restored;
        }
    }
}
