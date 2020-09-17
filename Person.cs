using System;
using System.Collections.Generic;
using System.Text;

namespace TestingEncapsulation
{
    class Person
    {
        private int Age;
        private string FName;
        private string LName;
        private int Weight;

        public int getAge()
        {
            return Age;
        }

        public void setAge(int age)
        {
            Age = age;
        }

        public string getFname()
        {
            return FName;
        }

        public void setFname(string fname)
        {
            FName = fname;
        }
        public string getLname()
        {
            return LName;
        }

        public void setLname(string LName)
        {
            this.LName = LName;
        }
        public int getWeight()
        {
            return Weight;
        }

        public void setWeight(int weight)
        {
            Weight = weight;
        }
    }
}
