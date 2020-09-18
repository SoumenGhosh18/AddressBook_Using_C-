using System;

namespace AddressBook 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To AddressBook Management program.....");
            {
                AddressBookImpl book = new AddressBookImpl();
                Boolean check = true;
                while (check == true)
                {
                    Console.WriteLine("1.Add_person 2.Display_person 3. Edit_person 4.Delete_person 5.Add_multiple person" +
                                        "6. choose_sort_By 7.View_Person_By_City");
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
                    else if (option == 5)
                    {
                        Console.WriteLine("Enter your first name");
                        String firstname = Console.ReadLine();
                        book.addMultiplePerson();
                    }
                    else if (option == 6)
                    {
                        book.sorting();
                    }
                    else if (option == 7)
                    {
                        Console.WriteLine("Enter the city");
                        String city = Console.ReadLine();
                        book.viewByCity(city);
                    }


                    else
                        check = false;
                }

            }
        }
    }
}
