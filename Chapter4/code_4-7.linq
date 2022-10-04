<Query Kind="Statements" />

#load "code_4-8"

dynamic example = new SimpleDynamicExample();
example.CallSomeMethod("x",10);
Console.WriteLine(example.SomeProperty);