using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace lesson2_task3
{
    class Spider
    {
        private Web web;

        public void SetWeb()
        {
            web = new Web();

        Start:
            Console.ResetColor();
            string userValue = Console.ReadLine();
            switch (userValue)
            {
                case "r":
                {
                    web.ChangeWebColor("Red");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("«Паутина {0} цвета»", web.WebColor);
                    goto Start;
                } 
                case "b":
                {
                    web.ChangeWebColor("Blue");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("«Паутина {0} цвета»", web.WebColor); 
                    goto Start;
                }
                case "w":
                {
                    web.ChangeWebColor("White");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("«Паутина {0} цвета»", web.WebColor);
                    goto Start;
                }
                case "y":
                {
                    web.ChangeWebColor("Yellow");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("«Паутина {0} цвета»", web.WebColor);
                    goto Start;
                }
                case "q":
                {
                    goto End;
                }
                default:
                {
                    Console.WriteLine("Нет подходящего цвета у паутины");
                    goto Start;
                }
                End:
                    break;
            }
        }
    }
}
