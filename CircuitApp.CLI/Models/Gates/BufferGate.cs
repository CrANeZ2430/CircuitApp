using CircuitApp.CLI.Models.Abstract;
using CircuitApp.CLI.Models.Core;

namespace CircuitApp.CLI.Models.Gates;

public class BufferGate(
    string name,
    Pin input)
    : Gate(name, [input])
{
    public override void Evaluate()
    {
        Output.SignalState = Inputs[0].SignalState;
    }
}