namespace CircuitApp.CLI.Models;

public class OutputObject(
    string name,
    Pin output)
    : CircuitObject(
        name)
{
    public Pin Output { get; private init; } = output;
}