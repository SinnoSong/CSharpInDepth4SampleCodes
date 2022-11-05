<Query Kind="Statements" />

#load "code_13-17"
#load "code_13-18"
using static VectorHelper;

var vector = new Vector3D(1.5, 2.0, 3.0);
var offset = new Vector3D(5.0, 2.5, -1.0);

vector.OffsetBy(offset);
Console.WriteLine($"({vector.X}, {vector.Y}, {vector.Z})");
Console.WriteLine(vector.Magnitude());