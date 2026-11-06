using CircuitApp.CLI.Models.Abstract;
using CircuitApp.CLI.Models.Core;

namespace CircuitApp.CLI.Models.Gates;

public class OrGate(
    string name,
    Pin[] inputs)
    : Gate(name, inputs)
{
    public override void Evaluate()
    {
        List<SignalState> inputStates = [.. Inputs.Select(input => input.SignalState)];

        if (inputStates.Contains(SignalState.High))
            Output.SignalState = SignalState.High;
        else if (inputStates.Contains(SignalState.Undefined))
            Output.SignalState = SignalState.Undefined;
        else
            Output.SignalState = SignalState.Low;
    }
}