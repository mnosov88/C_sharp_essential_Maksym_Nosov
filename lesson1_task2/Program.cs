using System;

namespace lesson1_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library1 = new Library();
            Library library2 = new Library("John", "Story of my life");

            library1.ExistingBook();
            Console.WriteLine("-");
            library2.ExistingBook();

            // delay
            Console.ReadKey();
        }
    }
}
