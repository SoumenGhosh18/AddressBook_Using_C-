using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class Sorting : IComparer
    {
        public void sortByName()
        {
            List.
        }
        int IComparer.Compare(Person x, Person y)
        {
            return x.getFirstName().CompareTo(y.getFirstName());
        
        }
    }
}
