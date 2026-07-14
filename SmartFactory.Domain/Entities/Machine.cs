namespace SmartFactory.Domain.Entities;

public class Machine
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Status { get; set; } = "Offline";

    public double Temperature { get; set; }

    public double Pressure { get; set; }

    public DateTime LastUpdated { get; set; }
}