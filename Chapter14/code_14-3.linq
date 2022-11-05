<Query Kind="Program" />

private struct MainLocals
{
    public int i;
}

static void Main()
{
    MainLocals locals = new MainLocals(); 
    locals.i = 0;
    AddToI(5, ref locals); 
    AddToI(10, ref locals);
    Console.WriteLine(locals.i);
}

static void AddToI(int amount, ref MainLocals locals) 
{
	locals.i += amount;
}