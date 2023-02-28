using Airport.Domain.Models.Entities;

namespace Airport.Domain.Models;

public class Airplane : EntityBase
{
    public string Model { get; set; }
    public double Fuel { get; set; }
    public int Seats { get; set; }
    public string CurrentFlight { get; set; }
}
