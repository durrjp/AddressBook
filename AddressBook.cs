using System.Collections.Generic;
using System.Linq;

namespace AddressBook
{
    public class AddressBook
    {
        List<Contact> allContacts = new List<Contact>();
        public void AddContact(Contact person)
        {
            allContacts.Add(person);
        }

        public Contact GetByEmail(string email)
        {
            Contact person = allContacts.First(p => p.Email == email);
            return person;
        }
    }
}