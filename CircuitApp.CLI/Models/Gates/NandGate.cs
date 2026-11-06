using CircuitApp.CLI.Models.Abstract;
using CircuitApp.CLI.Models.Core;

namespace CircuitApp.CLI.Models.Gates;

public class NandGate(
    string name,
    Pin[] inputs)
    : Gate(name, inputs)
{
    public override void Evaluate()
    {
        List<SignalState> inputStates = [.. Inputs.Select(input => input.SignalState)];

        if (inputStates.All(state => state == SignalState.High))
            Output.SignalState = SignalState.Low;
        else if (inputStates.Contains(SignalState.Low))
            Output.SignalState = SignalState.High;
        else
            Output.SignalState = SignalState.Undefined;
    }
}