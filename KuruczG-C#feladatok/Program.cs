using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KuruczG_C_feladatok
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.Write("Adja meg az összeget: ");
            //int osszeg = int.Parse(Console.ReadLine());
            //Console.Write("Adja meg hány évre szeretné lekötni: ");
            //int ev = int.Parse(Console.ReadLine());
            //Console.Write("Adja meg a kamatot: ");
            //double kamat = double.Parse(Console.ReadLine()) / 100;
            //double vegosszeg = osszeg * Math.Pow((1 + kamat), ev);
            //Console.WriteLine($"A végösszeg {vegosszeg} Ft");


            Console.WriteLine("---------------------------------------------------------------");








            double vKezdo;
            do
            {
                Console.Write("Add meg a kezdő sebességet (3.00–5.00 m/s): ");
                vKezdo = double.Parse(Console.ReadLine());
            }
            while (vKezdo < 3.0 || vKezdo > 5.00);
            const double tav = 100.0;
            double fele = tav / 2.0;
            double lassuloTav = 10;

            double vMax = vKezdo + 4.0;

            double a1 = (vMax - vKezdo) * (vMax + vKezdo) / (2 * fele);
            Console.WriteLine("tizmeterenkenti sebbesseg");
            for (int i = 10; i <= tav; i = i + 10)
            {
                double v;
                if (i <= fele)
                {
                    v = vKezdo + (vMax - vKezdo) * (i / fele);
                }
                else if (i > tav - lassuloTav)
                {
                    double vVeg = vMax / 2;
                    v = vMax - (vMax - vVeg) * ((i - (tav - lassuloTav)) / lassuloTav);
                }
                else
                {
                    v = vMax;
                }
                double vKmH = v * 3.6;
                Console.WriteLine($"{i,3} m: {vKmH,6:F2} km/h");

            }
        }
    }
}
