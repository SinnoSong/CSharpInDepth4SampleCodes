<Query Kind="Statements">
  <NuGetReference>Newtonsoft.Json</NuGetReference>
  <Namespace>Newtonsoft.Json.Linq</Namespace>
</Query>

string json = @"
    {
      'name': 'Jon Skeet',
      'address': {
        'town': 'Reading',
        'country': 'UK'
      }
    }".Replace('\'', '"');
JObject obj1 = JObject.Parse(json);
Console.WriteLine(obj1["address"]["town"]);

dynamic obj2 = obj1;
Console.WriteLine(obj2.address.town);