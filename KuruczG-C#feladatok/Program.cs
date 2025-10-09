using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuruczG_C_feladatok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adja meg az összeget: ");
            int osszeg = int.Parse(Console.ReadLine());
            Console.Write("Adja meg hány évre szeretné lekötni: ");
            int ev = int.Parse(Console.ReadLine());
            Console.Write("Adja meg a kamatot: ");
            double kamat = double.Parse(Console.ReadLine()) / 100;
            double vegosszeg = osszeg * kamat * ev + (osszeg * kamat);

            Console.WriteLine($"A végösszeg {vegosszeg} Ft");

        }
    }
}
