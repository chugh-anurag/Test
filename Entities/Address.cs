using Entities.Interfaces;
namespace Entities
{
    /// <summary>
    ///     Implement an interface to give properties to this class
    /// </summary>
    public class Address:IAddress
    {
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
    }
}