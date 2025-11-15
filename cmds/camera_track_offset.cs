using TagTool.Commands.Common;
using TagTool.Tags.Definitions.Common;

if (Args.Count > 1 || Args.Count < 1)
{
	Console.WriteLine("Error: Argument count invalid!");
	return false;
}

float offset = 0;

try
{
	offset = float.Parse(Args[0]);
}
catch (FormatException error)
{
	Console.WriteLine("Error: Argument was an invalid type!");
	Console.WriteLine(error.Message);
}

foreach (var point in Definition.ControlPoints)
{
	point.Position = new RealVector3d(point.Position.I, point.Position.J, point.Position.K += offset);
}

return true;