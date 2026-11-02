using CircuitApp.CLI.Models.Abstract;
using CircuitApp.CLI.Models.Core;

namespace CircuitApp.CLI.Models.Gates;

public class InputObject(
    string name,
    Pin input)
    : Component(name)
{
    public Pin Input { get; private set; } = input;
}