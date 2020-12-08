using System;
using System.Collections.Generic;
using System.Text;

namespace lesson2_task1
{
    partial class Worker
    {
        // show workers info
        public void ShowWorkerInfo()
        {
            Console.WriteLine("Workers name is {0}", Name);
            Console.WriteLine("Workers age is {0}", Age);
            Console.WriteLine("Workers work experience is {0}", WorkExperience);
        }
    }
}
