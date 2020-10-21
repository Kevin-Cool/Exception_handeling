using System;

namespace Exception_handling_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm alive!");
            int[] listIntegers = { 68,69,70 };
            string ant2 = "";
            while (ant2.ToLower() != "stop")
            {
                Console.Clear();
                try
                {
                    for (int i = 0; i < listIntegers.Length; i++)
                    {
                        if(i != 0) { Console.Write(", "); }
                        Console.Write((i+1)+": "+listIntegers[i]);
                    }
                    Console.Write("\nPlease select one:");
                    int ant  = int.Parse(Console.ReadLine());
                    Console.Write("\nYou selected: "+ listIntegers[ant-1]);
                }
                catch (IndexOutOfRangeException)
                {
                    Console.Write("\nThat number does not exist.");
                }
                catch (FormatException)
                {
                    Console.Write("\nPlease use numbers.");
                }
                catch (Exception)
                {
                    Console.Write("\nAn unexpected error occurred.");
                }
                Console.Write("\nPres enter to try again or type stop to stop: ");
                ant2 = Console.ReadLine();
            }
        }
    }
}
