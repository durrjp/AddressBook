using System.Collections.Generic;
using System.Linq;
using System;

namespace AddressBook
{
    public class AddressBook
    {
        Dictionary<string, Contact> allContacts = new Dictionary<string, Contact>();
        public void AddContact(Contact person)
        {
            try
            {
                allContacts.Add(person.Email, person);
            }
            catch (Exception)
            {
                Console.WriteLine("This person is already in the address book");
            }
        }
        public Contact GetByEmail(string email)
        {
            Contact person = allContacts[email];
            return person;
        }
    }
}