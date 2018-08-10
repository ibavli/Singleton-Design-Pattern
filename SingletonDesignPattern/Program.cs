using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var maindekisinifimiz = Sinif.SingletonIleSinifUret();
            maindekisinifimiz.EkranaMerhabaYaz();
            var maindekisinifimiz2 = Sinif.SingletonIleSinifUret();
            maindekisinifimiz2.EkranaMerhabaYaz();

            Console.ReadKey();
        }
    }

    class Sinif
    {
        private static Sinif sinif;
        static object kilit = new object();

        private Sinif()
        {

        }

        public static Sinif SingletonIleSinifUret()
        {
            lock (kilit)
            {
                if (sinif == null)
                {
                    sinif = new Sinif();
                }
            }
            return sinif;
        }
        public void EkranaMerhabaYaz()
        {
            Console.WriteLine("Merhaba Dünya");
        }

    }
}
