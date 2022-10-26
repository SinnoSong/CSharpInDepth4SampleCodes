<Query Kind="Statements">
  <Namespace>System.Globalization</Namespace>
</Query>

DateTime date = DateTime.UtcNow;
string parameter1 = string.Format(CultureInfo.InvariantCulture, "x={0:yyyy-MM-dd}", date);

string parameter2 = ((FormattableString)$"x={date:yyyy-MM-dd}").ToString(CultureInfo.InvariantCulture);

string parameter3 = FormattableString.Invariant($"x={date:yyyy-MM-dd}");
parameter1.Dump();
parameter2.Dump();
parameter3.Dump();