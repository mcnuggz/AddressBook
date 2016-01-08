using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Book
    {
        private string Name;
        private Entry Entry;
        Dictionary<string, Entry> addressBook = new Dictionary<string, Entry>();

        public void AddContact(string name, Entry entryInfo)
        {
            Name = name;
            Entry = entryInfo;

            Console.Clear();
            Console.WriteLine("Here you can add a entry to your address book.");
            Console.Write("Name: ");
            Name = Console.ReadLine();

            
        }

        public void RemoveContact()
        {
            string entryToRemove;

            Console.Clear();
            foreach (KeyValuePair<string, Entry> item in addressBook)
            {
                Console.WriteLine(item.Key);
            }
            Console.Write("Who would you like to remove?");
            entryToRemove = Console.ReadLine();

            addressBook.Remove(entryToRemove);
        }

        public void PrintBook()
        {
            Console.Clear();
            foreach (KeyValuePair<string, Entry> item in addressBook)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }

        public void EditBook()
        {
            Console.Clear();
        }

        public void SearchBook()
        {
            Console.Clear();
        }
    }
}
