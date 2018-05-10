using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Beckub_Copy.Models
{
    public enum TypeDVD { Oneside, TwoSide }

    public class DVD : Storage
    {
        public DVD(string model) : base(" ", model)
        {

        }

        public DVD() : this(0) { }

        public DVD(int SpeedWrite) : this(SpeedWrite, TypeDVD.Oneside){ }

        public DVD(int SpeedWrite, TypeDVD typeDVD) : base()
        {
            this.SpeedWrite = SpeedWrite;
            this.typeDVD = typeDVD;
        }

        public int SpeedWrite { get; set; }

        public int SpeedRead { get; set; }

        public TypeDVD typeDVD { get; set; }

        public override double GetMemory()
        {
            if (TypeDVD.Oneside == typeDVD)
                return 4.7;
            else
                return 9.4;
        }

        public override void Copy() { }

        public override void PrintInfo()
        {
            base.PrintInfo(); // вызываем то, что есть в Printinfo в базовом классе

            Console.WriteLine("Speed Write = " + SpeedWrite);
            Console.WriteLine("Type DVD = " + typeDVD);
        }
    }
}
