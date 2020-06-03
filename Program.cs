using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop2
{
    class TV
    {
        public static int channel = 0;
        public static string s = "";
    }
    class Program
    {  
        static void Main(string[] args)
        {
            
            Console.WriteLine("+ следующий канал, - предидущий канал, 'off' выключить");
            while (TV.s != "off")
                {
                TV.s = Console.ReadLine();
                if (TV.s == "+") Plus();
                if (TV.s == "-")
                {
                    if (TV.channel == 0) ;
                    else
                        Minus();
                }
                else Try();
                Console.WriteLine("Текущий канал " + TV.channel);
                }
            Console.Clear();

        }
        public static void Plus()
        {
            TV.channel++; 
        }

        public static void Minus()
        {
            TV.channel--;
        }
        public static void Try()
        {
            if (TV.s == "+") ;
            else
            {
                try
                {
                    if (Convert.ToInt32(TV.s) >= 0)

                        TV.channel = Convert.ToInt32(TV.s);
                    else
                        Console.WriteLine("Неверные данные");

                }
                catch
                {
                    Console.WriteLine("Неверные данные");

                }
            }
        }
    }
}
