<Query Kind="Program">
  <Namespace>System.Collections.Immutable</Namespace>
  <Namespace>System.Runtime.CompilerServices</Namespace>
</Query>

void Main()
{
	string[] source =
	{
		"the", "quick", "brown", "fox",
		"jumped", "over", "the", "lazy", "dog"
	};
	var query = from word in source
				where word.Length > 3
				orderby word
				select word.ToUpperInvariant();
	Console.WriteLine("Data:");
	Console.WriteLine(string.Join(",", query));
	Console.WriteLine("CallerInfo:");
	Console.WriteLine(string.Join(Environment.NewLine,query.CallerInfo));
}
public class CallerInfo
{
	public string File { get; }
	public int Line { get; }
	public string Member { get; }

	public CallerInfo(string file, int line, string member)
	{
		File = file;
		Line = line;
		Member = member;
	}

	public override string ToString() => $"{Path.GetFileName(File)}:{Line} - {Member}";
}

public static class CallerInfoEnumerableExtensions
{
	public static CallerInfoEnumerable<T> Where<T>(
		this IEnumerable<T> source,
		Func<T, bool> predicate,
		[CallerFilePath] string file = "Unspecified file",
		[CallerLineNumber] int line = -1,
		[CallerMemberName] string member = "Unspecified member") =>
		CombineInfo(source, Enumerable.Where(source, predicate), file, line, member);

	public static CallerInfoEnumerable<TResult> Select<TSource, TResult>(
		this IEnumerable<TSource> source,
		Func<TSource, TResult> selector,
		[CallerFilePath] string file = "Unspecified file",
		[CallerLineNumber] int line = -1,
		[CallerMemberName] string member = "Unspecified member") =>
		CombineInfo(source, Enumerable.Select(source, selector), file, line, member);

	private static CallerInfoEnumerable<TResult> CombineInfo<TOriginal, TResult>(
		IEnumerable<TOriginal> original,
		IEnumerable<TResult> result,
		string file,
		int line,
		string member)
	{
		var previousInfo =
			original is CallerInfoEnumerable<TOriginal> infoOriginal
			? infoOriginal.CallerInfo
			: ImmutableList.Create<CallerInfo>();
		var info = previousInfo.Add(new CallerInfo(file, line, member));
		return new CallerInfoEnumerable<TResult>(result, info);
	}
}

public class CallerInfoEnumerable<T> : IEnumerable<T>
{
	public IEnumerable<T> Data { get; }
	public ImmutableList<CallerInfo> CallerInfo { get; }

	internal CallerInfoEnumerable(IEnumerable<T> data, ImmutableList<CallerInfo> callerInfo)
	{
		Data = data;
		CallerInfo = callerInfo;
	}

	public IEnumerator<T> GetEnumerator() => Data.GetEnumerator();

	IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
