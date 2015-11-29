using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace group4_Lab3.DTL
{
    class Borrower
    {
        int borrowerNumber;
        char sex;
        


        public char Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public int BorrowerNumber
        {
            get { return borrowerNumber; }
            set { borrowerNumber = value; }
        }
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        string telephone;

        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }
        string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
