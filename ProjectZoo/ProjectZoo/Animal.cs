using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectZoo
{
    class Animal :IZoo
    {
        private int id;
        private String _Name;

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
               return _Name;
            }

            set
            {
                _Name = value;
            }
        }

        public string GetName()
        {
            return _Name;
        }
        public int GetID()
        {
            return id;
        }

        public Animal(int id, String name)
        {
            this.id = id;
            this._Name = name;
        }
        public Animal() { }
       public string ToString()
        {
            return "ID: " + this.id + "Name: " + this._Name;
        }
    }
}
