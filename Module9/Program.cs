using Beckub_Copy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9 // Наследование
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============================================================================================");
            Console.WriteLine();
            Console.Write("Введите объем данных - ");
            double temp = Double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("=============================================================================================");
            Console.WriteLine();

            GenerateDevice gd = new GenerateDevice();
            gd.generateFlash();
            gd.generateDVD();
            gd.generateHDD();
            

            Service serv = new Service();
            double totalMemoryFlash = serv.CalculateTotalMemory( new List<HDD>(), gd.fl, new List<DVD>());
            Console.WriteLine("Общий объем флешек = {0} ({1})", totalMemoryFlash, gd.fl.Count);
            
            TimeSpan timeFlash = serv.CalculateTotalTime(gd.fl);
            Console.WriteLine("Время копирования (в минутах) - " + timeFlash.TotalMinutes);
            Console.WriteLine();

            serv.getCount(ref gd.fl, temp);
            foreach (Flash item in gd.fl)
            {
                item.PrintInfo();
                Console.WriteLine();
            }

            Console.WriteLine("=============================================================================================");
            Console.WriteLine();

            double totalMemoryDvd = serv.CalculateTotalMemory(new List<HDD>(), new List<Flash>(), gd.dvd);
            Console.WriteLine("Общий объем DVD = {0} ({1})", totalMemoryDvd, gd.dvd.Count);

            TimeSpan timeDvd = serv.CalculateTotalTime(gd.dvd);
            Console.WriteLine("Время копирования (в минутах) - " + timeDvd.TotalMinutes);
            Console.WriteLine();

            serv.getCount(ref gd.dvd, temp);
            foreach (DVD item in gd.dvd)
            {
                item.PrintInfo();
                Console.WriteLine();
            }

            Console.WriteLine("=============================================================================================");
            Console.WriteLine();

            double totalMemoryHdd = serv.CalculateTotalMemory(gd.hdd, new List<Flash>(), new List<DVD>());
            Console.WriteLine("Общий объем HDD = {0} ({1})", totalMemoryHdd, gd.hdd.Count);

            TimeSpan timeHdd = serv.CalculateTotalTime(gd.hdd);
            Console.WriteLine("Время копирования (в минутах) - " + timeHdd.TotalMinutes);
            Console.WriteLine();

            serv.getCount(ref gd.hdd, temp);
            foreach (HDD item in gd.hdd)
            {
                item.PrintInfo();
                Console.WriteLine();
            }
            
            Console.WriteLine("=============================================================================================");            
        }
    }
}
