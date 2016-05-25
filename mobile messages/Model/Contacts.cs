using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobile_messages.Model
{
    public class Contacts
    {
        public List<Contact> contacts { get; set; }

        public Contacts() {

            contacts = new List<Contact>(4);

            contacts.Add(new Contact(1, "Jeremias", "Jeremy I"));
            contacts.Add(new Contact(2, "Pablo", "Jeremy II"));
            contacts.Add(new Contact(3, "Carlos", "Jeremy III"));
            contacts.Add(new Contact(4, "Andres", "Jeremy IV"));

        }

    }
}
