using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class AddressBookImpl : IAddressBook
    {
        Person person = null;

        List<Person> list = new List<Person>();

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
            list.Add(person);
        }

        public void delete(string firstName)
        {
            throw new NotImplementedException();
        }

        public void display()
        {
            foreach (Person p in list)
            {
                Console.WriteLine(p);
            }
        }
        public void edit(String firstName)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].getFirstName().Equals(firstName))
                {

                    Person person = list[i];
                    Console.WriteLine(person);

                    Console.WriteLine("enter new last name");
                    String lastName = Console.ReadLine();
                    person.LastName = lastName;

                    Console.WriteLine("enter new address");
                    person.Address = Console.ReadLine();
                   // person.setAddress(address);

                    Console.WriteLine("enter new city");
                    String city = Console.ReadLine();
                    person.setCity(city);

                    Console.WriteLine("enter new state");
                    String state = Console.ReadLine();
                    person.setState(state);

                    Console.WriteLine("enter new phoneNo");
                    String phoneNo = Console.ReadLine();
                    person.setMobileNo(phoneNo);

                    Console.WriteLine("enter new zipCode");
                    String zipCode = Console.ReadLine();
                    person.setZipcode(zipCode);
                }
            }
        }
        public void deletePerson(String firstName)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].FirstName.Equals(firstName))
                {
                    list.Remove(person);
                }
            }

        }
        public void addMultiplePerson()
        {
            Console.WriteLine("Enter your first name");
            String firstName = Console.ReadLine();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].getFirstName().Equals(firstName))
                {
                    Console.WriteLine("No duplicate entry acceptable please enter valid name");
                }
                else
                {
                
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
                    list.Add(person);

                }
            }
        }
        public void sortByName()
        {

            list.Sort(this.Compare);
            this.display();
        }

        public int Compare(Person x, Person y)
        {
            return x.getFirstName().CompareTo(y.getFirstName());

        }

    }

    }

