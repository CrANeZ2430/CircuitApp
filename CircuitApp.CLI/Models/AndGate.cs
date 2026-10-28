namespace CircuitApp.CLI.Models;

public class AndGate(
    string name, 
    IList<Pin> inputs, 
    IList<Pin> outputs)
    : CircuitObject(name)
{
    private IList<Pin> Inputs { get; init; } = inputs;
    private IList<Pin> Outputs { get; init; } = outputs;

    public void Evaluate()
    {
        if (Inputs[0].SignalState == SignalState.High && Inputs[1].SignalState == SignalState.High)
        {
            Outputs[0].SignalState = SignalState.High;
        }
        else if (Inputs[0].SignalState != SignalState.Undefined && Inputs[1].SignalState != SignalState.Undefined)
        {
            Outputs[0].SignalState = SignalState.Low;
        }
        else
        {
            Outputs[0].SignalState = SignalState.Undefined;
        }
    }
}