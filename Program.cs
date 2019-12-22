using System;

namespace ContohPemakaianClass__CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Mobil Bus = new Mobil();
            Mobil Angkot = new Mobil();

            Bus.Warna = "Merah";
            Bus.Kecepatan = 800;
            Bus.Klakson();

            Angkot.Warna = "Kuning";
            Angkot.Kecepatan = 300;
            Angkot.Klakson();

            Console.WriteLine("Warna Mobil Bus Adalah     : " + Bus.Warna);
            Console.WriteLine("Warna Mobil Angkot Adalah  : " + Angkot.Warna);

            Console.ReadLine();
        }
    }
}
