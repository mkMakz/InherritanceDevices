using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beckub_Copy.Models
{
    public abstract class Storage
    {
        public Storage() : this(" ") { }

        public Storage(string Name) : this(Name, " ") { }

        public Storage(string Name, string Model)
        {
            this.Name = Name;
            this.Model = Model;
        }

        public int Count { get; set; }

        static int Time { get; set; }

        protected string Name { get; set; }

        public string Model { get; protected set; }

        public abstract double GetMemory();

        public virtual void Copy()
        {
            Console.WriteLine("Copy start");
            Time = 2;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("{0} ({1})", Name, Model);
        }
        public static void PrintTime()
        {
            Console.WriteLine("{0} ({1})", Time);
        }
    }
}
