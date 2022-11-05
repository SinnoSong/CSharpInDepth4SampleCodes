<Query Kind="Program" />

public static double PublicMethod(LargeStruct first, LargeStruct second)
{
	double firstResult = PrivateMethod(in first);
	double secondResult = PrivateMethod(in second);
	return firstResult + secondResult;
}
public struct LargeStruct
{
	public double Weight { get; set; }
	public double Score { get; set; }
	public double X { get; set; }
	public double Y { get; set; }
	public double Z { get; set; }
}
private static double PrivateMethod(in LargeStruct input)
{
	double scale = GetScale(in input);
	return (input.X + input.Y + input.Z) * scale;
}
private static double GetScale(in LargeStruct input) => input.Weight * input.Score;