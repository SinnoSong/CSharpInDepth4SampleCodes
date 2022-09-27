<Query Kind="Statements" />

Action<string> action = (string message) =>
{
	Console.WriteLine("In delegate: {0}", message);
};

Action<string> action1 = (string message) => Console.WriteLine("In delegate: {0}", message);

Action<string> action2 = (message) => Console.WriteLine("In delegate: {0}", message);

Action<string> action3 = message => Console.WriteLine("In delegate: {0}", message);

//call
action("Message");
action1("Message");
action2("Message");
action3("Message");