using System.Data;

namespace CircuitApp.CLI.Models.Abstract;

public abstract class Component(
    string name)
{
    public Guid CircuitObjectId { get; private set; } = Guid.NewGuid();
    public string Name { get; set; } = name;
}