using System;
using System.Collections.Generic;

namespace Exception_handling_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm alive!");
            List<Cat> Kittens = new List<Cat>
            {
                new Cat(-1),
                new Cat(25),
                new Cat(20000000),
                new Cat(-20000000),
                new Cat(0),
                new Cat(3)
            };
            foreach (Cat Kitten in Kittens)
            {
                try
                {
                    Console.Write("\nKitten with age:" + Kitten.Age + " ");
                    Kitten.AgeCheck();
                    Console.Write("is possible.");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }




        }
    }
}
