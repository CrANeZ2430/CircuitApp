namespace CircuitApp.CLI.Models.Core;

public class Pin(string name, PinType pinType, SignalState signalState)
{
    public Guid PinId { get; private set; } = Guid.NewGuid();
    public string Name { get; private set; } = name;
    public PinType PinType { get; private set; } = pinType;
    public SignalState SignalState { get; set; } = signalState;
}