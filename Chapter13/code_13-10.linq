<Query Kind="Program" />

static readonly int field = DateTime.UtcNow.Second;
static ref readonly int GetFieldAlias() => ref field;
void Main()
{
	ref readonly int local = ref GetFieldAlias();
	Console.WriteLine(local);
}