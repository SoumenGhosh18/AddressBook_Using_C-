using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To AddressBook Management program.....");
            {
                IAddressBook book = new AddressBookImpl();
                Boolean check = true;
                while (check == true)
                {
                    Console.WriteLine("1.Add person 2.Display person 3. Edit person");
                    String read = Console.ReadLine();
                    int option1 = Convert.ToInt32(read);

                    if (option1 == 1)
                    {
                        book.add();
                    }

                    else if (option1 == 2)
                        book.display();
                    else if (option1 == 3)
                    {
                        Console.WriteLine("Enter your first name");
                        String firstname = Console.ReadLine();
                        book.edit(firstname);
                    }

                    else
                        check = false;
                }

            }
        }
    }
}
