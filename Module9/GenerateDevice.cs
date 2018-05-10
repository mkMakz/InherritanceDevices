using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Beckub_Copy.Models;

namespace Module9
{
    public class GenerateDevice
    {
        public GenerateDevice()
        {
            hdd = new List<HDD>();
            dvd = new List<DVD>();
            fl = new List<Flash>();
        }

        public List<HDD> hdd;
        public List <DVD> dvd;
        public List<Flash> fl;
        private Random rand = new Random();

        public void generateFlash()
        {
            for (int i = 0; i < rand.Next(1, 20); i++)
            {
                Flash flash = new Flash(string.Format("Model #{0}", rand.Next()));
                flash.MemoryFlash = rand.Next(2000, 128000);
                flash.typeDevice = (TypeDevice)rand.Next(0, 1);
                fl.Add(flash);
            }
        }

        public void generateDVD()
        {
            for (int i = 0; i < rand.Next(1, 20); i++)
            {
                DVD d = new DVD(string.Format("Model #{0}", rand.Next()));
                d.SpeedRead = rand.Next(2000, 128000);
                d.SpeedWrite = rand.Next(2000, 128000);
                d.typeDVD = (TypeDVD)rand.Next(0, 1);
                dvd.Add(d);
            }
        }

        public void generateHDD()
        {
            for (int i = 0; i < rand.Next(1, 20); i++)
            {
                HDD hd = new HDD(string.Format("Model #{0}", rand.Next()));
                hd.ClasterMomory = rand.Next(2000, 128000);
                hd.SpeedHDD = rand.Next(2000, 128000);
                hd.Claster = rand.Next(1000, 100000);
                //hd.Model = (TypeDVD)rand.Next(0, 1);
                hdd.Add(hd);
            }
        }
    }
}
