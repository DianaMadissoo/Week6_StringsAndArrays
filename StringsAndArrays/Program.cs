using System;

namespace StringsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutajal sisestada eesnime
            //programm kuvab kasutaja eesnime pikkuse

            Console.WriteLine("sisesta eesnimi:");
            string firstName = Console.ReadLine();

            //int firstNameLenght = firstName.Length;
            Console.WriteLine($"Sinu eesnimes on {firstName.Length} sumbolit.");
        }
    }
}
