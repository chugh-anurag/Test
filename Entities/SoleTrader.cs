using System.Collections.Generic;
using Entities.Interfaces;
namespace Entities
{
    /// <summary>
    /// </summary>
    public class SoleTrader : Company, IAddress
    {
        private string ppsn;
        public string Ppsn  // read-write instance property
        {
            get
            {
                return ppsn;
            }
            set
            {
                ppsn = value;
            }
        }

        private string name;
        public string Name  // read-write instance property
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        private string addressLine1;
        public string AddressLine1  // read-write instance property
        {
            get
            {
                return addressLine1;
            }
            set
            {
                addressLine1 = value;
            }
        }

        private string addressLine2;
        public string AddressLine2  // read-write instance property
        {
            get
            {
                return addressLine2;
            }
            set
            {
                addressLine2 = value;
            }
        }

        private string addressLine3;
        public string AddressLine3  // read-write instance property
        {
            get
            {
                return addressLine3;
            }
            set
            {
                addressLine3 = value;
            }
        }

        private string addressLine4;
        public string AddressLine4  // read-write instance property
        {
            get
            {
                return addressLine4;
            }
            set
            {
                addressLine4 = value;
            }
        }

        private List<Employment> employments;
        public List<Employment> Employments  // read-write instance property
        {
            get
            {
                return employments;
            }
            set
            {
                employments = value;
            }
        }
    }
}