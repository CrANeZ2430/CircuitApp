namespace CircuitApp.CLI.Models;

public class CircuitObject(
    string name)
{
    public Guid CircuitObjectId { get; private set; } = Guid.NewGuid();
    public string Name { get; set; }
}