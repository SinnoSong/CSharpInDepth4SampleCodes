<Query Kind="Statements">
  <Namespace>System.ComponentModel</Namespace>
  <Namespace>System.Runtime.CompilerServices</Namespace>
</Query>

class OldProperyNotifier : INotifyPropertyChanged
{
	public event PropertyChangedEventHandler PropertyChanged;

	private int firstValue;
	private int FirstValue
	{
		get { return firstValue; }
		set
		{
			if (value != firstValue)
			{
				firstValue = value;
				NotifyPropertyChanged();
			}
		}
	}

	private void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
	{
		PropertyChangedEventHandler handler = PropertyChanged;
		if (handler != null)
		{
			handler(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}