using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutajal sisestada ees ja perekonna nime
            //programm kontrollib andmete pikkust
            //programm kuvab kumb nendest on pikem, kas ees voi perekonna nimi
            
            Console.WriteLine("sisesta eesnimi:");
            string firstName = Console.ReadLine();
            int firstNameLenght = firstName.Length;

            Console.WriteLine("sisesta perekonnanimi:");
            string LastName = Console.ReadLine();
            int LastNameLenght = LastName.Length;

            if(firstNameLenght > LastNameLenght)
            {
                Console.WriteLine("Eesnimi on pikem, kui perekonnanimi");
            }
            else
            {
                Console.WriteLine("Perekonnanimi on pikem, kui eesnimi");
            }


        }
    }
}
