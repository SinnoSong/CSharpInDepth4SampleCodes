<Query Kind="Statements" />

List<int> list1 = new List<int>();
Console.WriteLine(list1.IsFixedSize);

IList list2 = list1;
Console.WriteLine(list2.IsFixedSize);

dynamic list3 = list1;
Console.WriteLine(list3.IsFixedSize);