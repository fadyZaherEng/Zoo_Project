using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectZoo
{
    class Manager :IZoo
    {
        private int id;
        private String _Name;
        
        public Manager() { }
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

        public Manager(int id, String name)
        {
            this.id = id;
            this._Name = name;
        }
        string IZoo.ToString()
        {
            return "ID: " + this.id + "Name: " + this._Name;
        }
    }
}
