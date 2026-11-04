using CircuitApp.CLI.Models.Abstract;
using CircuitApp.CLI.Models.Core;

namespace CircuitApp.CLI.Models.Gates;

public class AndGate(
    string name,
    Pin[] inputs)
    : Gate(name, inputs)
{
    public override void Evaluate()
    {
        List<SignalState> inputStates = [.. Inputs.Select(input => input.SignalState) ];
        
        if (inputStates.Contains(SignalState.Low))
            Output.SignalState = SignalState.Low;
        else if (inputStates.Contains(SignalState.Undefined))
            Output.SignalState = SignalState.Undefined;
        else
            Output.SignalState = SignalState.High;
    }
}