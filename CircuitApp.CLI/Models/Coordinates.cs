namespace CircuitApp.CLI.Models;

public struct Coordinates(double x, double y)
{
    public double X { get; private set; }
    public double Y { get; private set; }
}