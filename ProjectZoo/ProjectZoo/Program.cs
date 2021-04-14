using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            //add employee and his departments
            Address address = new Address("El marg", "16 Hassan Khalil");
            Employee employee = new Employee(1,"Ali Hassan",7000.0,8.0,address);
            Dept dept1 = new Dept(1, "Director");
            Dept dept2 = new Dept(1, "assistant Director");
            Dept dept3 = new Dept(1, "General Curator");
            Dept dept4 = new Dept(1, "Animal Curator");
            Dept dept5 = new Dept(1, "Veterinarian");
            Dept dept6 = new Dept(1, "Veterinarian Technical");

            DeptOfEmp deptOfEmp = new DeptOfEmp(employee);
            
            deptOfEmp.addDept(dept1);
            deptOfEmp.addDept(dept2);
            deptOfEmp.addDept(dept3);
            deptOfEmp.addDept(dept4);
            deptOfEmp.addDept(dept5);
            deptOfEmp.addDept(dept6);
            //add three samples
            Sample[] arr = new Sample[3];

            Animal animal1 = new Animal(1, "Fox");
            Sample sample1 = new Sample(animal1,1);
            arr[0] = sample1;
            Animal animal2 = new Animal(2, "Zebra");
            Sample sample2 = new Sample(animal2, 1);
            arr[1] = sample2;
            Animal animal3 = new Animal(3, "Lion");
            Sample sample3 = new Sample(animal3, 1);
            arr[2] = sample3;
            //add tow sampl for study
            Manager manager = new Manager(5,"Wael Hassan");
            Study study = new Study("1","Study1",employee,manager);
            study.addSample(sample1);
            study.addSample(sample2);
            Console.WriteLine(study.ToString());

            Console.WriteLine("New Study : --->");

            //add new samples and study it
            Address address1 = new Address("El Minia", "16 Hassan Khalil");
            Employee employee1 = new Employee(1, "Khaled Hassan", 7000.0, 8.0, address1);
            DeptOfEmp deptOfEmp2 = new DeptOfEmp(employee1);
            deptOfEmp2.addDept(dept1);
            deptOfEmp2.addDept(dept2);
            deptOfEmp2.addDept(dept3);
            deptOfEmp2.addDept(dept4);
            deptOfEmp2.addDept(dept5);
            deptOfEmp2.addDept(dept6);
            Manager manager1 = new Manager(4, "Mohamed Hassan");
            Study Newstudy = new Study("2", "Study2", employee1, manager1);
            Newstudy.addSample(new Sample(new Animal(7,"Panda"), 2));
            Newstudy.addSample(new Sample(new Animal(8,"Dog"), 2));
            Newstudy.addSample(new Sample(new Animal(9, "Puppy"), 2));
            Newstudy.addSample(new Sample(new Animal(10, "Kitten"), 2));
            Newstudy.addSample(new Sample(new Animal(11, "Cat"), 2));

            Console.WriteLine(Newstudy.ToString());
            Sample s =new Sample( new Animal(10, "Kitten"), 2);
            Newstudy.DropSample(s);
            Console.WriteLine("Samples Counter After Drop Is : ");
            Console.WriteLine(Newstudy.GetNumberOfSamples());
            Console.WriteLine("Samples After Drop Is : ");
            Sample[] Newarr = Newstudy.getSamples();
            for(int i = 0; i < Newstudy.GetNumberOfSamples(); i++)
            {
                Console.WriteLine("Sample Name IS : " + Newarr[i].GetAnimal().GetName());
            }
        }
    }
}
