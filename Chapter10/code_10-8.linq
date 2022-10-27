<Query Kind="Statements" />

#load "code_10-7"
SchemalessEntity parent = new SchemalessEntity { Key = "parent-key" };
SchemalessEntity child1 = new SchemalessEntity
{
	{"name","Sinno Song"},
	{"location","hangzhou,CN"}
};
child1.Key = "child-key";
child1.ParentKey = parent.Key;

SchemalessEntity child2 = new SchemalessEntity
{
	Key = "child-key",

	ParentKey = parent.Key,
	["name"] = "Jon Skeet",
	["location"] = "Reading, UK"
};