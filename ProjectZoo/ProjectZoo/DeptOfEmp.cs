using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectZoo
{
    class DeptOfEmp
    {
        private Employee employee;
        private Dept []arr;
        private int deptCounts;
        public DeptOfEmp(Employee emp )
        {
            arr = new Dept[6];
            this.employee = emp;
            this.deptCounts = 0;
        }
        public int getNumberOfDepts()
        {
            return this.deptCounts;
        }
        public Dept[] getDepts()
        {
            return this.arr;
        }
        public void addDept(Dept dept)
        {
            arr[this.deptCounts] = dept;
            this.deptCounts++;
        }
        public String ToString()
        {
            String ret="Employee Name Is: "+ employee.Name+"\n";
            
            for(int i = 0; i < this.deptCounts; i++)
            {
                ret +="Dept Name:"+(i+1)+" "+ arr[i].Name+"\n";
            }
            return ret;
        }
    }
}
