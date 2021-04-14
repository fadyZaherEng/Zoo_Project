using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectZoo
{
    class Dept:IZoo
    {
        private int id;
        private String _Name;
        private Address address;
        public int ID
        {
            get
            {
                return this.id;
            }

            set
            {
                this.id = value;
            }
        }
        public string Name
        {
            get
            {
                return this._Name;
            }

            set
            {
                this._Name = value;
            }
        }
        public Address addresses
        {
            get
            {
                return this.address;
            }
            set
            {
                this.address = value;
            }
        }
        public Dept(int id, String name)
        {
            this.id = id;
            this._Name = name;
        }
        public string ToString()
        {
            return "ID: " + this.id + "Name: " + this._Name;
        }

    }
}
