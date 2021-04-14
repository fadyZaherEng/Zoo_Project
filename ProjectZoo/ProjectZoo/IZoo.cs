using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectZoo
{
    interface IZoo
    {
         int ID { get; set; }
         String Name { get; set; }
         String ToString();
    }
}
