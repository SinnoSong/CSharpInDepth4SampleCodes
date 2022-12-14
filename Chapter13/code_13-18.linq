<Query Kind="Program" />

#load "code_13-17"

public static class VectorHelper
{
	public static double Magnitude(this in Vector3D vec) =>
	Math.Sqrt(vec.X * vec.X + vec.Y * vec.Y + vec.Z * vec.Z);
	public static void OffsetBy(this ref Vector3D orig, in Vector3D off) =>
		orig = new Vector3D(orig.X + off.X, orig.Y + off.Y, orig.Z + off.Z);
}