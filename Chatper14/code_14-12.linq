<Query Kind="Program" />

enum SampleEnum {}
static void EnumMethod<T>() where T : struct, Enum {}
static void DelegateMethod<T>() where T : Delegate {}
static void UnmanagedMethod<T>() where T : unmanaged {}
void Main()
{
	EnumMethod<SampleEnum>();
	//EnumMethod<Enum>(); //非法，不符合struct类型约束

	DelegateMethod<Action>();
	DelegateMethod<Delegate>();
	DelegateMethod<MulticastDelegate>();

	UnmanagedMethod<int>();
	//UnmanagedMethod<string>(); // 非法，string 是托管类型
}
