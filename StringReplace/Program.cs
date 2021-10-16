using System;

namespace StringReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab koik 'o' tahed lauses "Hello, world!" tarniga (*)

            string helloWorld = "Hello World!";

            /* for(int i =0; i < helloWorld.Length; i++)
            {
                helloWorld[i] = '*'; //soned on muutumatud
            }*/

            helloWorld = helloWorld.Replace('o', '*');
            helloWorld = helloWorld.Replace('!', '1');

            Console.WriteLine(helloWorld);
        }
    }
}
