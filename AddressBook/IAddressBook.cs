using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    interface IAddressBook
    {
        public void add();
        public void display();
        public void edit(String firstName);
        public void deletePerson(String firstName);
        public void addMultiplePerson();
        public void sorting();
        public void viewByCity(String city);
    }
}
