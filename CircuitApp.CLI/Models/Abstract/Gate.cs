using CircuitApp.CLI.Models.Core;

namespace CircuitApp.CLI.Models.Abstract;

public abstract class Gate(
    string name,
    Pin[] inputs) 
    : Component(name)
{
    protected Pin[] Inputs { get; private set; } = inputs;
    public Pin Output { get; private set; } = new("O", PinType.Output, SignalState.Undefined);

    public abstract void Evaluate();
}