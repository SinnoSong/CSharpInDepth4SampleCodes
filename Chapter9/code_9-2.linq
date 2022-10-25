<Query Kind="Statements">
  <Namespace>System.Globalization</Namespace>
</Query>

var cultures = CultureInfo.GetCultures(CultureTypes.AllCultures);
var birthDate = new DateTime(1999, 2, 19);
foreach (var culture in cultures)
{
	string text = string.Format(culture, "{0,-15} {1,12:d}", culture.Name, birthDate);
	Console.WriteLine(text);
}