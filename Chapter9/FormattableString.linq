<Query Kind="Statements">
  <Namespace>System.Globalization</Namespace>
</Query>

var dateOfBirth = new DateTime(1999, 2, 19);
FormattableString formattableString = $"宋锦辉 was born on {dateOfBirth:d}";
var culture = CultureInfo.GetCultureInfo("zh-CN");
var result = formattableString.ToString(culture);
result.Dump();