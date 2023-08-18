using System;

namespace TervehdysNimellä
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kysytään käyttäjältä nimi ja tallennetaan se muuttujaan
            Console.WriteLine("Syötä nimesi:");
            string nimi = Console.ReadLine();

            // Tulostetaan tervehdys käyttäjän nimellä
            Console.WriteLine("Hei " + nimi);

            // Pysäytetään ohjelma odottamaan syötettä ennen sulkemista
            Console.ReadLine();
        }
    }
}
