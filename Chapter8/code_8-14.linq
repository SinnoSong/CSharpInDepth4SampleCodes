<Query Kind="Statements">
  <NuGetReference>NodaTime</NuGetReference>
  <Namespace>NodaTime</Namespace>
</Query>

public struct LocalDateTime
{
	public LocalDate Date { get; }
	public int Year => Date.Year;
	public int Month => Date.Month;
	public int Day => Date.Day;

	public LocalTime TimeOfDay { get; }
	public int Hour => TimeOfDay.Hour;
	public int Minute => TimeOfDay.Minute;
	public int Second => TimeOfDay.Second;
}