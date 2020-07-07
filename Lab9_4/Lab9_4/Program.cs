using System;
using System.IO;
using System.Text;

namespace Lab9_4
{
    class Header
    {
        public const string open = "<h1>";
        public const string close = "</h1>";

        public string CreateHeader(string text)
        {
            string header = String.Concat(open, text, close, "\n");
            return header;
        }
    }

    class Paragraph
    {
        public const string open = "<p>";
        public const string close = "</p>";

        public string CreateParagraph(string text)
        {
            string words = String.Concat(open, text, close, "\n");
            return words;
        }
    }

    class UnorderedList
    {
        public const string open = "<ul>";
        public const string close = "</ul>";

        public string CreateListItem(string text)
        {
            string open = "<li>\n";
            string close = "</li>\n";

            string listItem = String.Concat(open, text, close, "\n");
            return listItem;
        }

        public StringBuilder CreateList(string[] listItems)
        {

            StringBuilder sb = new StringBuilder();
            sb.Append(open);
            foreach (string item in listItems)
            {
                sb.Append(item);
            }
            sb.Append(close);

            return sb;
        }

    }




    class Program
    {
        static void Main(string[] args)
        {
            string filename = "C:\\Users\\Jackass\\Desktop\\SD1104\\Lab9_4\\FoodSite.html";
            Header header = new Header();
            Paragraph paragraph = new Paragraph();
            UnorderedList list = new UnorderedList();
            StringBuilder sb = new StringBuilder();

            Console.WriteLine("Enter text for the header:");
            string headerElement = header.CreateHeader(Console.ReadLine());
            string[] listItems = new string[3];

            for (int i = 0; i < listItems.Length; i++)
            {
                Console.WriteLine("Add another item to the list:");
                listItems[i] = list.CreateListItem(Console.ReadLine());
            }

            Console.WriteLine("Enter text for a paragraph:");
            string paragraphElement = paragraph.CreateParagraph(Console.ReadLine());
            
            StringBuilder listElement = list.CreateList(listItems);
 
            sb.Append(headerElement);
            sb.Append(listElement.ToString());
            sb.Append(paragraphElement);

            File.AppendAllText(filename, sb.ToString());

        }
    }
}
