using CircuitApp.CLI.Models.Abstract;
using CircuitApp.CLI.Models.Core;

namespace CircuitApp.CLI.Models.Gates;

public class XorGate(
    string name,
    Pin[] inputs)
    : Gate(name, inputs)
{
    public override void Evaluate()
    {
        var s0 = Inputs[0].SignalState;
        var s1 = Inputs[1].SignalState;

        if (s0 == SignalState.Undefined || s1 == SignalState.Undefined)
        {
            Output.SignalState = SignalState.Undefined;
        }
        else
        {
            Output.SignalState = (s0 == SignalState.High) ^ (s1 == SignalState.High)
                ? SignalState.High
                : SignalState.Low;
        }
    }
}