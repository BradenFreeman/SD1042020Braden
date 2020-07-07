using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Lab7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            DatingProfile Seth = new DatingProfile("Seth", "Quincy", 27, "Male");
            Seth.WriteBio("Loves to sit down for hours and talk about the philisophical implications of eating.");

            DatingProfile Jessica = new DatingProfile("Jessica", "Meitner", 30, "Female");
            Jessica.WriteBio("Loves to go to the mall and watch people, watch people.");

            DatingProfile Laura = new DatingProfile("Laura", "Shultz", 22, "Female");
            Laura.WriteBio("Loves to talk about the affect of piano on the human psyche in the 18th Century.");

            Seth.SendMessage("What's up Jessica?", "Lets go to the mall.", Jessica);
            Jessica.ReadMessage();

            Jessica.SendMessage("Hi Seth, sure let's go.", "At 8?", Seth);
            Seth.ReadMessage();

            Seth.SendMessage("Hi Laura.", "Thats a nice piano you have there.", Laura);
            Laura.ReadMessage();

            Laura.SendMessage("Hiya Seth.", "Thanks :) it was my grandma's.", Seth);
            Seth.ReadMessage();

        }
    }
    class DatingProfile
    {
        public string firstName;
        private string lastName;
        public int age;
        public string gender;
        public string bio;
        private List<Messages> myMessages;

        public DatingProfile(string firstName, string lastName, int age, string gender)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.gender = gender;
            myMessages = new List<Messages>();
        }
        public void WriteBio(string text)
        {
            bio = text;
        }
        public void AddToInbox(Messages message)
        {
            myMessages.Add(message);

        }
        public void SendMessage(string messageTitle, string messageData, DatingProfile sentTo)
        {
            Messages message = new Messages(this, messageTitle, messageData);
            sentTo.AddToInbox(message);
        }
        public void ReadMessage()
        {
            foreach (Messages message in myMessages)
            {
                if (message.isRead == false)
                {
                    Console.WriteLine(message.sender.firstName + " " + "sent you a message.");
                    Console.WriteLine(message.messageTitle);
                    Console.WriteLine(message.messageData);
                    message.isRead = true;
                    
                }
            }
        }

    }
    class Messages
    {
        public DatingProfile sender;
        public string messageTitle;
        public string messageData;
        public bool isRead;

        public Messages(DatingProfile sender, string messageTitle, string messageData)
        {
            this.sender = sender;
            this.messageTitle = messageTitle;
            this.messageData = messageData;
            isRead = false;
        }

    }
}
