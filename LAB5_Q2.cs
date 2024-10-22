using System;

public class Customer
{
    public string CustomerId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Constructor
    public Customer(string Id, string FName, string LName)
    {
        CustomerId = Id;
        FirstName = FName;
        LastName = LName;
    }
}

public class RetailCustomer : Customer
{
    public string CreditCardType { get; set; }
    public string CreditCardNo { get; set; }

    public RetailCustomer(string Id, string FName, string LName, string CType, string CNo) : base(Id, FName, LName)
    {
        CreditCardType = CType;
        CreditCardNo = CNo;
    }
}

public class CorporateCustomer : Customer
{
    public string CompanyName { get; set; }
    public int FrequentFlyerPoints { get; set; }

    public CorporateCustomer(string Id, string FName, string LName, string companyName, int points) : base(Id, FName, LName)
    {
        CompanyName = companyName;
        FrequentFlyerPoints = points;
    }
}

public class Reservation
{
    public string ReservationNo { get; set; }
    public DateTime Date { get; set; }

    public Reservation(string No, DateTime date)
    {
        ReservationNo = No;
        Date = date;
    }
}

public class Seat
{
    public int RowNo { get; set; }
    public int SeatNo { get; set; }
    public decimal Price { get; set; }

    public Seat(int rowNo, int seatNo, decimal price)
    {
        RowNo = rowNo;
        SeatNo = seatNo;
        Price = price;
    }
}

public class Flight
{
    public string FlightId { get; set; }
    public DateTime Date { get; set; }
    public string Origin { get; set; }
    public string Destination { get; set; }

    public Flight(string flightId, DateTime date, string origin, string destination)
    {
        FlightId = flightId;
        Date = date;
        Origin = origin;
        Destination = destination;
    }
}

class Program
{
    static void Main()
    {
        // Creating and displaying a retail customer
        RetailCustomer retailCustomer = new RetailCustomer("233598", "Musa", "Munir", "Visa", "1234-5678-910-11");
        Console.WriteLine($"Retail Customer: {retailCustomer.FirstName} {retailCustomer.LastName}, Card: {retailCustomer.CreditCardType} - {retailCustomer.CreditCardNo}");

        // Creating and displaying a corporate customer
        CorporateCustomer corpCustomer = new CorporateCustomer("233600", "Hanan", "Zia", "Avatar", 10000);
        Console.WriteLine($"Corporate Customer: {corpCustomer.FirstName} {corpCustomer.LastName}, Company: {corpCustomer.CompanyName}, Points: {corpCustomer.FrequentFlyerPoints}");
    }
}
