using System;
using System.Drawing;

namespace Lab2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int First = 19;
            int Second = 244;
            Console.WriteLine(First * Second);
            string myText = "Some text";
            Console.WriteLine(myText);
            string moreText = " goes here.";
            Console.WriteLine(moreText);
            Console.WriteLine(myText + moreText);
            string color1 = "Yellow";
            string color2 = "Red";
            bool isYellow = true;
            bool isGreen = false;
            Console.WriteLine(color1, isYellow, color2, isGreen);
            double numbers;
            numbers = (Second / First);
            Console.WriteLine(numbers);
            Console.WriteLine("Break Point Here.");
            string textToNumber = "80473";
            int results = 99 * int.Parse(textToNumber);
            DateTime rightNow = DateTime.Now;
            Console.WriteLine(rightNow);
        }
    }
}
