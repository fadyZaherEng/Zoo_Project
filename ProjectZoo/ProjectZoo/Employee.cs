using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectZoo
{
    class Employee : IZoo
    {
        private int id;
        private String _Name;
        private double Salary;
        private double WeeklyHours;
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
        public Employee(int id,String name,double sal,double hours,Address add)
        {
            this.id = id;
            this._Name = name;
            this.Salary = sal;
            this.WeeklyHours = hours;
           
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
        public Employee()
        {
        }
        public double NetSalary()
        {
            return this.WeeklyHours * this.Salary;
        }
        public string ToString()
        {
            return "ID: " + this.id + " Name: " + this._Name;
        }
    }
}
