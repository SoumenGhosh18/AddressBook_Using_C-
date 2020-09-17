using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class Person
    {
        private String firstName;
        private String lastName;
        private String address;
        private String city;
        private String state;
        private String zip;
        private String phoneNumber;

        public Person(String firstName, String lastName, String address,
                      String city, String state, String phoneNumber, String zip)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.PhoneNumber = phoneNumber;
            this.Zip = zip;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string Zip { get => zip; set => zip = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        public override string ToString()
        {
            return "[firstName=" + firstName + ", lastName=" + lastName + ", address=" + address + ", city=" + city
                 + ", state=" + state + ", zipCode=" + Zip + ", PhoneNo=" + PhoneNumber + "]" + "\n";
        }
    }
    }

