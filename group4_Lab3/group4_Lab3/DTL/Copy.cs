using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace group4_Lab3.DTL
{
    class Copy
    {
        int copyNumber;

        public int CopyNumber
        {
            get { return copyNumber; }
            set { copyNumber = value; }
        }
        int bookNumber;

        public int BookNumber
        {
            get { return bookNumber; }
            set { bookNumber = value; }
        }
        int sequenceNumber;

        public int SequenceNumber
        {
            get { return sequenceNumber; }
            set { sequenceNumber = value; }
        }
        char type;

        public char Type
        {
            get { return type; }
            set { type = value; }
        }
        double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
