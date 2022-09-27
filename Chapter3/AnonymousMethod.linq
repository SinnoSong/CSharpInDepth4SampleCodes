<Query Kind="Statements" />

Action<string> action = delegate (string message)
{
	Console.WriteLine("In delegate: {0}",message);
};
action("Message"); //call delegate