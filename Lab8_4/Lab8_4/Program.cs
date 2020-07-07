using System;

namespace Lab8_5
{


    class Application
    {
        public string firstName;
        public string lastName;
        public string dateOfBirth;
        public string address;
        public string city;
        public string state;
        public int zip;
        public string phoneNumber;
        public string email;
        public bool isSubmitted;
        public bool isAccepted;

        public Application(string firstName, string lastName, string dateOfBirth, string address, string city, string state, int zip, string phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.email = email;
            isSubmitted = false;
            isAccepted = false;

        }


        public void Submit()
        {
            isSubmitted = true;
            Console.WriteLine("Application has been submitted");
        }

        public virtual void Accept()
        {
            isAccepted = true;
            Console.WriteLine("Application Accepted");
        }
    }

    class HouseHunter : Application
    {
        public string jobTitle;
        public int currentAnnualIncome;
        public int whenBuyingMonths;
        public int bedrooms;
        public int bathrooms;

        public HouseHunter(string jobTitle, int currentIncome, int moveinmonth, int bedrooms, int bathrooms,
            string firstName, string lastName, string dateOfBirth, string address, string city, string state, int zip,
            string phoneNumber, string email) : base(firstName, lastName, dateOfBirth, address, city, state, zip, phoneNumber, email)
        {

            this.jobTitle = jobTitle;
            this.currentAnnualIncome = currentIncome;
            this.whenBuyingMonths = moveinmonth;
            this.bedrooms = bedrooms;
            this.bathrooms = bathrooms;
        }

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("You've been accepted to Dream House Hunters");
        }
    }

    class ParadiseIsland : Application
    {
        public string gender;
        public string nameOfBoyOrGirlFriend;
        public int yearsDating;

        public ParadiseIsland(string gender, string nameOfBoyOrGirlFriend, int yearsDating,
            string firstName, string lastName, string dateOfBirth, string address, string city, string state, int zip,
            string phoneNumber, string email) : base(firstName, lastName, dateOfBirth, address, city, state, zip, phoneNumber, email)
        {

            this.gender = gender;
            this.nameOfBoyOrGirlFriend = nameOfBoyOrGirlFriend;
            this.yearsDating = yearsDating;
        }

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("You've been accepted to Paradise Island");
        }
    }
    class AboveDeck : Application
    {
        public int yearsExperience;
        public string nationality;

        public AboveDeck(int yearsExperience, string nationality,
            string firstName, string lastName, string dateOfBirth, string address, string city, string state, int zip,
            string phoneNumber, string email) : base(firstName, lastName, dateOfBirth, address, city, state, zip, phoneNumber, email)
        {

            this.yearsExperience = yearsExperience;
            this.nationality = nationality;
        }

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("You've been accepted to Above Deck");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            HouseHunter hhContestant = new HouseHunter("HeadHunter", 77777, 6, 5, 4, "Clancy", "Porter", "02/13/2000",
                "888 Elm Street", "Richmond", "Virginia", 58982, "777-876-7777", "clancyisgreat@gmail.com");

            ParadiseIsland piContestant = new ParadiseIsland("Female", "Carl", 2, "Patti", "Johnson", "5/4/1994", "211 Love Rd", "Los Angeles",
                "California", 90001, "988-444-1234", "patti.johnson@gmail.com");

            AboveDeck adContestant = new AboveDeck(20, "American", "Captian", "Lee", "7/12/1964", "311 Bravo Rd", "Los Angeles",
            "California", 90001, "711-333-1234", "captian@gmail.com");

            hhContestant.Submit();
            hhContestant.Accept();

            piContestant.Submit();
            piContestant.Accept();

            adContestant.Submit();
            adContestant.Accept();


        }
    }
}
