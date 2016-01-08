using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Program
    {

        static void Main(string[] args)
        {
            Book addressBook = new Book();
            bool menu = true;

            while (menu == true)
            {
                Console.WriteLine("Welcome to your Address Book");
                Console.WriteLine("*****************************");
                Console.WriteLine("Press 1 to Add an entry to the address book");
                Console.WriteLine("Press 2 to Remove any entry in the address book");
                Console.WriteLine("Press 3 to Print the book to the screen");
                Console.WriteLine("Press 4 to Edit a record");
                Console.WriteLine("Press 5 to Search for a record");
                Console.WriteLine("Press 6 to Exit the program");
                int input = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("");

                switch (input)
                {
                    case 1:
                        //add entry
                        break;
                    case 2:
                        //remove entry
                        break;
                    case 3:
                        //print book
                        addressBook.PrintBook();
                        break;
                    case 4:
                        //edit entries
                        
                        break;
                    case 5:
                        //search for object in dictionary

                        break;
                    case 6:
                        menu = false;
                        break;
                    default:
                        if (input > 6)
                        {
                            Console.WriteLine("Invalid submission. Please select 1, 2, 3, 4, or 5.");
                        }
                        break;
                }
            }
        }
    }
}
