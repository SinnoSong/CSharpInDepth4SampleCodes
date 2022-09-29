<Query Kind="Statements" />

dynamic d = new object();
int invalid1 = "text".Substring(0, 1, 2, d); // does not exist 4 arguments method
bool invalid2 = string.Equals<int>("foo", d); // does not exist Equals<int>
string invalid3 = new string(d, "broken"); //does not exist 2 arguments ctor 
char invalid4 = "text"[d,d]; // does not exist 2 arguments indexer