using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beckub_Copy.Models
{
    public class Service
    {
        public double CalculateTotalMemory(List<HDD> hdds, List<Flash> flashs, List<DVD> dvds) //●	расчет общего количества памяти всех устройств;
        {
            double result = 0;

            foreach (HDD item in hdds)
                result += item.GetMemory();

            foreach (Flash item in flashs)
                result += item.GetMemory();

            foreach (DVD item in dvds)
                result += item.GetMemory();

            return result;
        }

        public TimeSpan CalculateTotalTime(List<HDD> hdds)
        {
            double sum = 0;

            foreach (HDD item in hdds)
            {
                sum += item.ClasterMomory * item.SpeedHDD;
            }
            return TimeSpan.FromMilliseconds(sum);
        } //●	расчет времени необходимого для копирования;

        public TimeSpan CalculateTotalTime(List<Flash> flashs)
        {
            double sum = 0;

            foreach (Flash item in flashs)
            {
                sum += item.MemoryFlash * item.SpeedFlash;
            }
            return TimeSpan.FromMilliseconds(sum);
        } //●	расчет времени необходимого для копирования;

        public TimeSpan CalculateTotalTime(List<DVD> dvds)
        {
            double sum = 0;

            foreach (DVD item in dvds)
            {
                sum += item.GetMemory() * item.SpeedRead;
            }
            return TimeSpan.FromMilliseconds(sum);
        } //●	расчет времени необходимого для копирования;

        //private int DevoceCounter(Flash flash, double MemirtData, out int count) // out int count -  возвращает в переменную
        //{
        //    count = Int32.Parse(Math.Ceiling((MemirtData / flash.MemoryFlash)).ToString()); // конвертор БЛЯ + округлитель
        //}
        //----------------------------------------------------------------------------------------------------------------------------

        private int DeviceCounter( Flash flash, double MemirtData) // out int count -  возвращает в переменную
        {
              return Int32.Parse( Math.Ceiling((MemirtData / flash.MemoryFlash)).ToString()); // конвертор БЛЯ + округлитель
        }

        public void getCount(ref List<Flash> flash, double MemoriData)
        {
            foreach (Flash item in flash)
            {
               item.Count =  DeviceCounter( item, MemoriData);
            }
        }
       
        private int DeviceCounter( DVD dvd, double MemirtData) // ref ссылка !!!!!!!!!!!!!!!!!!!
        {
            return  Int32.Parse(Math.Ceiling((MemirtData / dvd.GetMemory())).ToString()); // конвертор БЛЯ + округлитель   
        }

        public void getCount(ref List<DVD> dvd, double MemoriData)
        {
            foreach (DVD item in dvd)
            {
                item.Count = DeviceCounter(item, MemoriData);
            }
        }
     
        private int DeviceCounter( HDD hdd, double MemirtData) // ref ссылка !!!!!!!!!!!!!!!!!!!
        {
            return  Int32.Parse(Math.Ceiling((MemirtData / hdd.GetMemory())).ToString()); // конвертор БЛЯ + округлитель
        }

        public void getCount(ref List<HDD> hdd, double MemoriData)
        {
            foreach (HDD item in hdd)
            {
                item.Count = DeviceCounter(item, MemoriData);
            }
        }
    }
}
