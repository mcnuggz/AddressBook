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
        private string PhoneNumber;
        SortedDictionary<string, string> addressBook = new SortedDictionary<string, string>();
        
        public void AddContact()
        {
            Console.Clear();
            Console.WriteLine("Here you can add a entry to your address book.");
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Phone Number: ");
            PhoneNumber = Console.ReadLine();

            addressBook[Name] = PhoneNumber;
            
            Console.WriteLine(Environment.NewLine +  "Added " + Name + Environment.NewLine);           
        }

        public void RemoveContact()
        {
            string entryToRemove;
            string userConfirm;

            Console.Clear();
            foreach (KeyValuePair<string, string> item in addressBook)
            {
                Console.WriteLine(item.Key);
            }
            Console.Write("Who would you like to remove? ");
            entryToRemove = Console.ReadLine();

            Console.Write("Are you sure? ");
            userConfirm = Console.ReadLine().ToLower();

            if(userConfirm == "yes")
            {
                if (addressBook.Remove(entryToRemove))
                {
                    Console.WriteLine(entryToRemove + " is removed" + Environment.NewLine);
                }
                else
                {
                    Console.WriteLine(entryToRemove + " does not exist" + Environment.NewLine);
                }
                
            }
            else
            {
                RemoveContact();
            }
        }

        public void PrintBook()
        {
            Console.Clear();
            Console.WriteLine("Contacts");
            Console.WriteLine("*****************************");
            foreach (KeyValuePair<string, string> item in addressBook)
            {
                Console.WriteLine(item.Key + ": " + item.Value + Environment.NewLine);
            }
        }

        public void EditBook()
        {
            string entryToFind;
            string newValue;
            string userInput;

            Console.Clear();
            Console.Write("Enter contact: ");
            entryToFind = Console.ReadLine();

            if (addressBook.ContainsKey(entryToFind))
            {
                Console.WriteLine("Update Number?");
                userInput = Console.ReadLine().ToLower();
                if (userInput == "yes")
                {
                    Console.Write("Enter new phone number: ");
                    newValue = Console.ReadLine();
                    addressBook[entryToFind] = newValue;

                    Console.WriteLine(Environment.NewLine +"Contact Updated");
                    Console.WriteLine(entryToFind + ": " + newValue + Environment.NewLine);
                }
                else if(userInput != "yes" || userInput != "no")
                {
                    Console.WriteLine(Environment.NewLine + "Enter either yes or no" + Environment.NewLine );
                }
            }
        }

        public void SearchBook()
        {
            string entryToFind;
                   
            Console.Clear();
            Console.WriteLine("Who are you trying to find?");
            entryToFind = Console.ReadLine();

            if (addressBook.ContainsKey(entryToFind))
            {
                string value = addressBook[entryToFind];
                Console.WriteLine(Environment.NewLine + entryToFind + ": " + value + Environment.NewLine);
            }
            else
            {
                Console.WriteLine(Environment.NewLine + "Contact not found" + Environment.NewLine);
            }
        }
    }
}