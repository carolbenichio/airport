using Airport.Domain.Models.Entities;

namespace Airport.Domain.Models;

public class Airline : EntityBase
{
    public string Name { get; set; }
    public string Lane { get; set; }
    public List<Airplane> Airplanes { get; set; }
    public int ManeuverDuration { get; set; } // minutos
}
