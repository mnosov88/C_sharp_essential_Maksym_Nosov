using System;

namespace lesson2_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Spider spider = new Spider();
            spider.SetWeb();

            // delay
            Console.ReadKey();

        }
    }
}
