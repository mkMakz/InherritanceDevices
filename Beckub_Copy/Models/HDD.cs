using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Beckub_Copy.Models
{
    public class HDD : Storage
    {
        public HDD(string model) : base(" ", model)
        {

        }

        public HDD() : this(0) { }

        public HDD(int SpeedHDD) : this(SpeedHDD, TypeDevice.USB2) { }

        public HDD(int SpeedHDD, TypeDevice typeDevice) : base()
        {
            this.SpeedHDD = SpeedHDD;
            this.typeDevice = typeDevice;
        }

        public int SpeedHDD { get; set; }

        public TypeDevice typeDevice { get; set; }

        public int Claster { get; set; }

        public int ClasterMomory { get; set; }

        public override double GetMemory()
        {
            return ClasterMomory;
        }

        public override void PrintInfo()
        {
            base.PrintInfo(); // вызываем то, что есть в Printinfo в базовом классе

            Console.WriteLine("Speed HDD = " + SpeedHDD);
            Console.WriteLine("Type device = " + typeDevice);
            Console.WriteLine("Claster = " + typeDevice);
            Console.WriteLine("Claster Momory = " + ClasterMomory);
        }

        public override void Copy() //●	копирование информации на устройства;
        {
            int sum = ClasterMomory / SpeedHDD;

            for (int i = 0; i < sum; i++)
            {
                Console.WriteLine(".");
                Thread.Sleep(500); // засыпание на 500 мили сек.
            }
        }
    }
}