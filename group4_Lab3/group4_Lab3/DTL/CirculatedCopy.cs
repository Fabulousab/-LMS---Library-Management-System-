using System;

namespace group4_Lab3.DTL
{
    public class CirculatedCopy
    {
        int id;
        int copyNumber;
        int borrowerNumber;
        DateTime borrowedDate;
        DateTime returnDate;
        double fineAmount;

        public int ID { get; set; }
        public int CopyNumber { get; set; }
        public int BorrowerNumber { get; set; }

        public DateTime BorrowedDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public double FineAmount { get; set; }
        public CirculatedCopy()
        {

        }


    }
}
