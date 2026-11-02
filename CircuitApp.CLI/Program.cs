using CircuitApp.CLI.Models;
using CircuitApp.CLI.Models.Abstract;
using CircuitApp.CLI.Models.Core;
using CircuitApp.CLI.Models.Gates;

var input1 = new InputObject("In1", new Pin("A", PinType.Input, SignalState.High));
var input2 = new InputObject("In2", new Pin("A", PinType.Input, SignalState.High));

var xor1 = new XorGate("Xor1", [input1.Input, input2.Input]);
var and = new AndGate("And", [input1.Input, input2.Input]);
var xor2 = new XorGate("Xor2", [and.Output, xor1.Output]);

var output = new OutputObject("Out", xor2.Output);

var dic = new Dictionary<int, Gate[]> { { 0, [and, xor1] }, { 1, [xor2]} };
var graph = new CircuitGraph(dic, output);
graph.Evaluate();
Console.Write(graph.Output.Output.SignalState);