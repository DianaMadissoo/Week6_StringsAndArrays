using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab koik 'o' tahed lauses "Don't Panic" nulliga - 0
            //programm asendab koik 'a' tahed samas lauses 4-ga

            string sentence = "Don't Panic!";

            sentence = sentence.Replace('o', '0');
            sentence = sentence.Replace('a', '4');

            Console.WriteLine(sentence);
        }
    }
}
