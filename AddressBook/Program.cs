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
                    Console.WriteLine("1.ADD 2.Display");
                    String option = Console.ReadLine();
                    int option1 = Convert.ToInt32(option);

                    if (option1 == 1)
                    {
                        book.add();
                    }

                    else if (option1 == 2)
                        book.display();

                    else
                        check = false;
                }

            }
        }
    }
}
