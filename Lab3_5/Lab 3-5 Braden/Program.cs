using System;

namespace Lab_3_5_Braden
{
    class Program
    {
        static void Main(string[] args)
        {
            string blackListWord = "car";
            bool isSpam = false;
            string message = Console.ReadLine();
            if (message.Contains(blackListWord))
            {
                isSpam = true;
                Console.WriteLine("This message is spam, stop it.");
            }
            else
            {
                isSpam = false;
                Console.WriteLine("This message is not spam, good boy.");
            }
        }
    }
}
