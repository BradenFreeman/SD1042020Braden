using System;
using System.Collections.Generic;

namespace Lab5_2
{
    class Program
    {

        public enum Days
        {
            Sunsday,
            Moonsday,
            Twosday,
            WedNesDay,
            Thorsday,
            Frysday,
            Saturnsday
        }

        static void Main(string[] args)
        {
            //List to hold the Tasks
            List<string> taskList = new List<string>();

            foreach (Days day in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine("Enter your task for " + day);
                string task = day + " : " + Console.ReadLine();
                taskList.Add(task);
            }

            foreach (string task in taskList)
            {
                Console.WriteLine(task);
            }
        }
    }
}
