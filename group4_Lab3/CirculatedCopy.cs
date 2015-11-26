using System;

public class CirculatedCopy
{
    int id;
    int CopyNumber;
    int borrowerNumber;
    DateTime borrowedDate;
    DateTime returnDate;
    double fineAmount;

    public int id { get; set; }
    public int CopyNumber { get; set; }
    public int borrowerNumber { get; set; }

    public DateTime borrowedDate { get; set; }
    public DateTime returnDate { get; set; }
    public double fineAmount { get; set; }
    public CirculatedCopy()
	{
        
	}


}
