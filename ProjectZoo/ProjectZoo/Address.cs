using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectZoo
{
    class Address
    {
        private String City;
        private String StreetNo;
        public Address (String City,String Street)
        {
            this.City = City;
            this.StreetNo = Street; 
        }
        public String city() {
            return City;
        }
        public String StreetNum()
        {
            return StreetNo;
        }

        public String ToString()
        {
            return "City: " + this.City + "     StreetNo: " + this.StreetNo;
        }
    }
}
