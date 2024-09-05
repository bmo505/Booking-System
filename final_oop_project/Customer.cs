using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_oop_project
{
    class Customer
    {
        string name;
        string email;
        public Customer()
        { }
        public Customer(string name, string email)
        {
            this.name = name;
            this.email = email;
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string Email
        {
            set { email = value; }
            get { return email; }
        }
    }
}
