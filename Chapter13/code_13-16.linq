<Query Kind="Statements" />

#load "code_13-15"

class ImplicitFieldCopy
{
	private readonly YearMonthDay readOnlyField = new YearMonthDay(2018, 3, 1);
	private YearMonthDay readWriteField = new YearMonthDay(2018, 3, 1);

	public void CheckYear()
	{
		int readOnlyFieldYear = readOnlyField.Year;
		int readWriteFieldYear = readWriteField.Year;
	}
}