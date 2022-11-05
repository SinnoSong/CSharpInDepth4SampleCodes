<Query Kind="Statements" />

class ParsedText
{
	public string Text { get; }
	public bool Valid { get; }
	protected ParsedText(string text, bool valid)
	{
		Text = text;
		Valid = valid;
	}
}
class ParsedInt32 : ParsedText
{
	public int? Value { get; }
	public ParsedInt32(string text) : base(text, int.TryParse(text, out int parseResult)
	{
		Value = Valid ? parseResult : (int?)null;
	}
}