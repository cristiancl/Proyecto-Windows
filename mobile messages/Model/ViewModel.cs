using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobile_messages.Model
{
    public class ViewModel
    {

        public Contacts contacts { get; set; }

        public ViewModel() {

            contacts = new Contacts();

        }

    }
}
