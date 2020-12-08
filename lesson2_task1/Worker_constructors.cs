using System;
using System.Collections.Generic;
using System.Text;

namespace lesson2_task1
{
    partial class Worker
    {
        // default constructor
        public Worker() { }

        // user's constructor
        public Worker(string name, double age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Worker(string name, double age, double workExperience)
        {
            this.Age = age;
            this.Name = name;
            this.WorkExperience = workExperience;
        }
    }
}
