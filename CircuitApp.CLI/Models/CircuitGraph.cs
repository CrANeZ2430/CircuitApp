using CircuitApp.CLI.Models.Abstract;
using CircuitApp.CLI.Models.Gates;

namespace CircuitApp.CLI.Models;

public class CircuitGraph(
    Dictionary<int, Gate[]> components,
    OutputObject output)
{
    private Dictionary<int, Gate[]> Components { get; set; } = components;
    public OutputObject Output { get; private set; } = output;

    public void Evaluate()
    {
        for (var i = 0; i < Components.Keys.Count; i++)
        {
            foreach (var component in Components[i])
            {
                component.Evaluate();
            }
        }
    }
}