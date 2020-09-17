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
                    Console.WriteLine("1.Add person 2.Display person 3. Edit person 4.Delete person");
                    String read = Console.ReadLine();
                   int option = Convert.ToInt32(read);

                    if (option == 1)
                    {
                        book.add();
                    }

                    else if (option == 2)
                        book.display();
                    else if (option == 3)
                    {
                        Console.WriteLine("Enter your first name");
                        String firstname = Console.ReadLine();
                        book.edit(firstname);
                    }
                    else if (option == 4)
                    {
                        Console.WriteLine("Enter your first name");
                        String firstname = Console.ReadLine();
                        book.deletePerson(firstname);
                    }

                    else
                        check = false;
                }

            }
        }
    }
}
