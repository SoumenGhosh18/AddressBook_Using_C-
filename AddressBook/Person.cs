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

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string Zip { get => zip; set => zip = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

           public Person(String firstName, String lastName, String address,
                         String city, String state, String zip, String phoneNumber)
           {
               this.firstName = firstName;
               this.lastName = lastName;
               this.address = address;
               this.city = city;
               this.state = state;
               this.zip = zip;
               this.phoneNumber = phoneNumber;
           }
        /*
           public String getFirstName()
           {
               return firstName;
           }
           public void setFirstName(String firstName)
           {
               this.firstName = firstName;
           }
           public String getLastName()
           {
               return lastName;
           }
           public void setLastName(String lastName)
           {
               this.lastName = lastName;
           }
           public String getAddress()
           {
               return address;
           }
           public void setAddress(String address)
           {
               this.address = address;
           }
           public String getCity()
           {
               return city;
           }
           public void setCity(String city)
           {
               this.city = city;
           }
           public String getState()
           {
               return state;
           }
           public void setState(String state)
           {
               this.state = state;
           }
           public String getZipcode()
           {
               return zip;
           }
           public void setZipcode(String zip)
           {
               this.zip = zip;
           }
           public String getPhoneNumber()
           {
               return phoneNumber;
           }
           public void setMobileNo(String phoneNumber)
           {
               this.phoneNumber = phoneNumber;
           }
        */
        public override string ToString()
        {
            return "[firstName=" + FirstName + ", lastName=" + LastName + ", address=" + Address + ", city=" + City
                 + ", state=" + State + ", zipCode=" + Zip + ", PhoneNo=" + PhoneNumber + "]" + "\n";
        }
    }
    }

