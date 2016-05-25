using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobile_messages.Model
{
    public class Contact : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public int UserId { get; set; }
        public String UserName { get; set; }
        public String contactName { get; set; }

        public Contact(int UserId, String UserName, String contactName) {

            this.UserId = UserId;
            this.UserName = UserName;
            this.contactName = contactName;

        }

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

        
}

