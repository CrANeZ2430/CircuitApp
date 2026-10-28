using CircuitApp.CLI.Models;

var input1 = new InputObject("In1", new Pin("A", PinType.Input, SignalState.Low));
var input2 = new InputObject("In2", new Pin("A", PinType.Input, SignalState.Low));
var output = new OutputObject("Out", new Pin("A", PinType.Output, SignalState.Undefined));
var andGate = new AndGate("And", new List<Pin>() {input1.Input, input2.Input}, new List<Pin>() {output.Output});
andGate.Evaluate();
Console.Write(output.Output.SignalState);