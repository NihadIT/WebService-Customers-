using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Customers
{
    public class Customer : INotifyPropertyChanged
    {
        public int _customerID;
        public int CustomerID
        {
            get { return this._customerID; }
            set
            {
                this._customerID = value;
                this.OnPropertyChanged(nameof(CustomerID));
            }
        }

        public string _title;
        public string Title
        {
            get { return this._title; }
            set
            {
                this._title = value;
                this.OnPropertyChanged(nameof(Title));
            }
        }

        public string _firstName;
        public string FirstName
        {
            get { return this._firstName; }
            set
            {
                this._firstName = value;
                this.OnPropertyChanged(nameof(FirstName));
            }
        }

        public string _lastName;
        public string LastName
        {
            get { return this._lastName; }
            set
            {
                this._lastName = value;
                this.OnPropertyChanged(nameof(LastName));
            }
        }

        public string _emailAddress;
        public string EmailAddress
        {
            get { return this._emailAddress; }
            set
            {
                this._emailAddress = value;
                this.OnPropertyChanged(nameof(EmailAddress));
            }
        }

        public string _phone;
        public string Phone
        {
            get { return this._phone; }
            set
            {
                this._phone = value;
                this.OnPropertyChanged(nameof(Phone));
            }
        }

        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedData { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
