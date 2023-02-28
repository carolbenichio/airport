namespace Airport.Domain.Models;

public class Flight
{
    public string From { get; set; } // TODO: create "Trecho"
    public string To { get; set; }
    public Airline Airline { get; set; }
    public Airplane Airplane { get; set; }
    public DateTime Date { get; set; }
    public int Duration { get; set; } // minutes
    public DateTime ArrivalTime { get; set; }
    public DateTime DepartureTime { get; set; }
    public int Passengers { get; set; }
    public Lane Lane { get; set; }
}
