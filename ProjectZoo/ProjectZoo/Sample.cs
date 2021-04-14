using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectZoo
{
    class Sample :Animal
    {
        private Animal animal;
        private static double SampleID;
        private static int SampleCount;


        public Sample(Animal animal,double SampleId)
        {
            this.animal = animal;
            SampleID = SampleId;
            SampleCount++;
        }
        public Animal GetAnimal()
        {
            return animal;
        }
        public static int sampleCounter {
            get
            {
                return SampleCount;
            }
       }
        public  double sampleId()
        {
                return SampleID;
            
        }
        public string ToString()
        {
            return "Sample ID: "+SampleID+"Animal Id: "+animal.ID+"Animal Name: "+animal.Name;
        }

    }
}
