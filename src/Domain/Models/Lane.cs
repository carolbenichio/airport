using Airport.Domain.Models.Entities;

namespace Airport.Domain.Models;

public class Lane : EntityBase
{
    public string Name { get; set; }
    public bool Available { get; set; }
    public List<Airline> PermitedAirlines { get; set; } // needed?
}
