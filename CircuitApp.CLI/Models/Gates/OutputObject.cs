using CircuitApp.CLI.Models.Abstract;
using CircuitApp.CLI.Models.Core;

namespace CircuitApp.CLI.Models.Gates;

public class OutputObject(
    string name,
    Pin output)
    : Component(
        name)
{
    public Pin Output { get; private set; } = output;
}