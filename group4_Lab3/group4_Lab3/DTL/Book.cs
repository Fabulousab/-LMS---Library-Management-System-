using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace group4_Lab3.DTL
{
    class Book
    {
        int bookNumber;

        public int BookNumber
        {
            get { return bookNumber; }
            set { bookNumber = value; }
        }
        string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        string authors;

        public string Authors
        {
            get { return authors; }
            set { authors = value; }
        }
        string publisher;

        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }
    }
}
