<Query Kind="Statements">
  <Namespace>System.Globalization</Namespace>
</Query>

var compositeFormatString = "宋锦辉 was born on {0:d}";
var value = new DateTime(1999, 2, 19);
var culture = CultureInfo.GetCultureInfo("zh-CN");
var result = string.Format(culture, compositeFormatString, value);
Console.WriteLine(result);