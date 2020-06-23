using System;
using System.ComponentModel;

namespace Lab5_6
{
    class Program
    {

        public struct Customer
        {
            public string first_name;
            public string last_name;
            public string gender;
            public int age;
            public bool hasMembership;
            public string residentstate;
            public string alignment;
        }

        static void Main(string[] args)
        {

            Customer customer1 = new Customer();
            Customer customer2 = new Customer();
            Customer customer3 = new Customer();
            Customer customer4 = new Customer();

            customer1.first_name = "Mike";
            customer1.last_name = "Smith";
            customer1.age = 17;
            customer1.gender = "Male";
            customer1.hasMembership = false;
            customer1.residentstate = "Texas";
            customer1.alignment = "Chaotic Neutral";

            customer2.first_name = "John";
            customer2.last_name = "White";
            customer2.age = 43;
            customer2.gender = "Male";
            customer2.hasMembership = false;
            customer2.residentstate = "Virginia";
            customer2.alignment = "Lawful Good";

            customer3.first_name = "Alex";
            customer3.last_name = "Nuka";
            customer3.age = 22;
            customer3.gender = "Female";
            customer3.hasMembership = true;
            customer3.residentstate = "Alaska";
            customer3.alignment = "Chaotic Good";

            customer4.first_name = "Clifford";
            customer4.last_name = "the Dog";
            customer4.age = 22;
            customer4.gender = "Male-Dog";
            customer4.hasMembership = true;
            customer4.residentstate = "Texas";
            customer4.alignment = "Lawful Neutral";

            Customer[] allCustomers = { customer1, customer2, customer3, customer4};

            for (int i = 0; i < allCustomers.Length; i++)
            {
                if (allCustomers[i].age < 21)
                {
                    int x = allCustomers[i].age;
                    int y = 7;
                    int sum = allCustomers[i].age * y;
                    Console.WriteLine(allCustomers[i].first_name + " " + allCustomers[i].last_name + " would be able to order if their age was changed to dog years: " + " " + sum);
                }

                if (allCustomers[i].age < 21)
                {
                    
                    Console.WriteLine(allCustomers[i].first_name + " " + allCustomers[i].last_name + " is not allowed to place an order");
                }
                else
                {
                    Console.WriteLine(allCustomers[i].first_name + " " + allCustomers[i].last_name + " can place an order");
                }

                if (allCustomers[i].hasMembership == true)
                {
                    Console.WriteLine(allCustomers[i].first_name + " " + allCustomers[i].last_name + " is a premium member.");
                }
                else
                {
                    Console.WriteLine(allCustomers[i].first_name + " " + allCustomers[i].last_name + " is a standard member.");
                }
                if (allCustomers[i].gender == "Male")
                {
                    Console.WriteLine(allCustomers[i].first_name + " " + allCustomers[i].last_name + " does not qualify for a discout.");
                }
                else if (allCustomers[i].gender == "Female")
                {
                    Console.WriteLine(allCustomers[i].first_name + " " + allCustomers[i].last_name + " qualifies for a 10 percent discout.");
                }
                else
                {
                    Console.WriteLine(allCustomers[i].first_name + " " + allCustomers[i].last_name + " qualifies for a 20 percent discout.");
                }

                if (allCustomers[i].residentstate == "Texas")
                {
                    Console.WriteLine(allCustomers[i].first_name + " " + allCustomers[i].last_name + " does not get promotional item.");
                }
                else
                {
                    Console.WriteLine(allCustomers[i].first_name + " " + allCustomers[i].last_name + " gets a free, Don't Mess with Texas, sticker.");
                }
                if (allCustomers[i].alignment == "Chaotic Neutral")
                {
                    Console.WriteLine(allCustomers[i].first_name + " " + allCustomers[i].last_name + " gets a free, gray and red D20.");
                }
                else if (allCustomers[i].alignment == "Lawful Good")
                {
                    Console.WriteLine(allCustomers[i].first_name + " " + allCustomers[i].last_name + " gets a free, blue and gold D20.");
                }
                else if (allCustomers[i].alignment == "Chaotic Good")
                {
                    Console.WriteLine(allCustomers[i].first_name + " " + allCustomers[i].last_name + " gets a free, red and blue D20.");
                }
                else if (allCustomers[i].alignment == "Lawful Neutral")
                {
                    Console.WriteLine(allCustomers[i].first_name + " " + allCustomers[i].last_name + " gets a free, gray and black D20.");
                }
                else
                {
                    Console.WriteLine(allCustomers[i].first_name + " " + allCustomers[i].last_name + " gets a free D8 of their color choice.");
                }
            }
        }
    }
}