using System;
using System.Collections.Generic;
using System.Text;

namespace lesson2_task2
{
    class Pie
    {
        private readonly DateTime manufacturingDate;
        public Pie() 
        {
            this.manufacturingDate = DateTime.Now;
        }

        public void GetManufacturingDate()
        {
            Console.WriteLine(manufacturingDate);
        }
    }
}
