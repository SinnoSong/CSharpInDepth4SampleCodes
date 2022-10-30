<Query Kind="Program" />

void Main()
{
	var Ab = ("A", "b"); 
	var aB = ("a", "B");
	var aa = ("a", "a");
	var ba = ("b", "a");

	Compare(Ab, aB);
	Compare(aB, aa);
	Compare(aB, ba);
}
static void Compare<T>(T x, T y) where T : IStructuralEquatable, IStructuralComparable
{
	var comparison = x.CompareTo(y, StringComparer.OrdinalIgnoreCase); //不区分大小写的排序和等价比较
	var equal = x.Equals(y, StringComparer.OrdinalIgnoreCase);

	Console.WriteLine($"{x} and {y} - comparsion : {comparison};equal :{equal}");
}