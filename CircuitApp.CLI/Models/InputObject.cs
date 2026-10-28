namespace CircuitApp.CLI.Models;

public class InputObject(
    string name,
    Pin input)
    : CircuitObject(name)
{
    public Pin Input { get; private init; } = input;
}