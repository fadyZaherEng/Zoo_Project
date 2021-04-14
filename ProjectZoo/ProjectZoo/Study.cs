using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectZoo
{
    class Study
    {
        private String StudyId;
        private String StudyName;
        private Employee employee;
        private Manager manager;
        private Sample[] SampleArr;
        private int NumerOfSample = 0;
        public Study() {
            SampleArr = new Sample[15];
            employee = new Employee();
            manager = new Manager();
        }
        public Study(String id,String name,Employee emp,Manager man)
        {
            this.StudyId = id;
            this.StudyName = name;
            SampleArr = new Sample[15];
            employee = emp;
            manager =man;
        }
        public String StudyID
        {
            get
            {
                return this.StudyId;
            }

            set
            {
                this.StudyId = value;
            }
        }
        public String studyName
        {
            get
            {
                return this.StudyName;
            }

            set
            {
                this.StudyName = value;
            }
        }
        public int GetNumberOfSamples()
        {
            return NumerOfSample;
        }
        public Sample[] getSamples()
        {
            return SampleArr;
        }
        public void addSample(Sample sample)
        {
            SampleArr[NumerOfSample] = sample;
            NumerOfSample++;
        }

        public string ToString()
        {
            string ret = "Study Id: "+this.StudyId+"  Study Name: "+this.StudyName+"\n";
            for(int i = 0; i < NumerOfSample; i++)
            {
                ret += "Sample ID Number " + (i + 1)+" Is : " + SampleArr[i].sampleId()+ "\n";
            }
            return ret;
        }
        public void DropSample(Sample sample)
        
        {
            int count = -1;
            for (int i = 0; i < NumerOfSample ; i++)
            {
                if(sample.GetAnimal().GetName()== SampleArr[i].GetAnimal().GetName()){
                    count = i;
                    break;
                }
            }
            ////////////////////////////////////////////

            if (count != -1)
            {
                for (int i = count; i < NumerOfSample-1; i++)
                {
                    SampleArr[i] = SampleArr[i + 1];
                }
            }
            NumerOfSample--;
        }
    }
}
