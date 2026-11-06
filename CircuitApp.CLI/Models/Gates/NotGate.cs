using CircuitApp.CLI.Models.Abstract;
using CircuitApp.CLI.Models.Core;

namespace CircuitApp.CLI.Models.Gates;

public class NotGate(
    string name,
    Pin input)
    : Gate(name, [input])
{
    public override void Evaluate()
    {
        SignalState inputState = Inputs[0].SignalState;

        Output.SignalState = inputState switch
        {
            SignalState.High => SignalState.Low,
            SignalState.Low => SignalState.High,
            _ => SignalState.Undefined,
        };
    }
}