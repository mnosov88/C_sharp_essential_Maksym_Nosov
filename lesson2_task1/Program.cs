using System;

namespace lesson2_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            // initializa objects
            Worker worker1 = new Worker()
            {
                Name = "Name1",
                Age = 18,
                WorkExperience = 0
            };
            Worker worker2 = new Worker("Name2", 18);
            Worker worker3 = new Worker("Name3", 30, 2);

            // show workers info
            worker1.ShowWorkerInfo();
            worker2.ShowWorkerInfo();
            worker3.ShowWorkerInfo();

            // delay
            Console.ReadKey();
        }
    }
}
