using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class AddressBookImpl : IAddressBook
    {

        LinkedList<Person> list = new LinkedList<Person>();

        public void add()
        {

            Console.WriteLine("Enter the First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter your Address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter the City");
            string city = Console.ReadLine();
            Console.WriteLine("Enter the State");
            string state = Console.ReadLine();
            Console.WriteLine("Enter your Zip Code");
            string zip = Console.ReadLine();
            Console.WriteLine("Enter your phone number");
            string phoneNumber = Console.ReadLine();
            Person person = new Person(firstName, lastName, address, city, state, zip, phoneNumber);
            list.AddFirst(person);
        }
        public void display()
        {
            foreach (Person p in list)
            {
                Console.WriteLine(p);
            }
        }
    }
}
