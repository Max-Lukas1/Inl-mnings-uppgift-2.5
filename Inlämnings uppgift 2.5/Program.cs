using System;
namespace inlämningsuppgift_2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett decimaltal");
            string Decimaltal1=Console.ReadLine();
            Double Decimaltals1=Double.Parse(Decimaltal1);

            Console.WriteLine("Skriv ett till decimaltal");
            string Decimaltal2 = Console.ReadLine();
            Double Decimaltals2 = Double.Parse(Decimaltal1);

            Double svar=Decimaltals1*Decimaltals2;
            Console.WriteLine(svar);
        }
    }
}

