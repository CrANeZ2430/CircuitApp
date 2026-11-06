using CircuitApp.CLI.Models.Abstract;
using CircuitApp.CLI.Models.Core;

namespace CircuitApp.CLI.Models.Gates;

public class XnorGate(
    string name,
    Pin[] inputs)
    : Gate(name, inputs)
{
    public override void Evaluate()
    {
        List<SignalState> inputStates = [.. Inputs.Select(input => input.SignalState)];

        if (inputStates.Contains(SignalState.Undefined))
            Output.SignalState = SignalState.Undefined;
        else if (inputStates.Count(state => state == SignalState.High) % 2 == 0)
            Output.SignalState = SignalState.High;
        else
            Output.SignalState = SignalState.Low;
    }
}