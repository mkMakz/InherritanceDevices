using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beckub_Copy.Models
{
    public enum TypeDevice { USB2, USB3}

    public class Flash : Storage
    {
        public Flash(string model) : base(" ", model)
        {

        }

        public Flash() : this(0) { }

        public Flash(int SpeedFlash) : this(SpeedFlash, 0) { }

        public Flash(int SpeedFlash, double MemoryFlash) : base()
        {
            this.MemoryFlash = MemoryFlash;
            this.SpeedFlash = SpeedFlash;
        }

        public int SpeedFlash { get; private set; }

        public double MemoryFlash { get; set; }

        private TypeDevice typeDevice_;

        public TypeDevice typeDevice {
            get
            {
                return typeDevice_;
            }
            set
            {
                typeDevice_ = value;

                if (TypeDevice.USB2 == value)
                    SpeedFlash = 2000;
                else
                    SpeedFlash = 3000;
            }
        }

        public override double GetMemory()
        {
            return MemoryFlash;
        }

        public override void PrintInfo()
        {
            base.PrintInfo(); // вызываем то, что есть в Printinfo в базовом классе

            Console.WriteLine("Speed Flash = " + SpeedFlash);
            Console.WriteLine("Memory Flash = " + MemoryFlash);
            Console.WriteLine("Type Device = " + typeDevice);
        }
    }
}
