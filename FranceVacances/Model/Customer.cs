using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranceVacances.Model
{
    class Customer
    {
        private String name;
        private String phoneNumber;
        private String email;
        private String password;

        public Customer(String Name, String PhoneNumber, String Email, String Password)
        {
            name = Name;
            phoneNumber = PhoneNumber;
            email = Email;
            password = Password;
        }

        public string Name
        {
            get { return name; }
        }
        
    }
}
