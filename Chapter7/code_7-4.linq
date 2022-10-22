<Query Kind="Statements">
  <Namespace>System.ComponentModel</Namespace>
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
				NotifyPropertyChanged(nameof(FirstValue));
			}
		}
	}

	private void NotifyPropertyChanged(string propertyName)
	{
		PropertyChangedEventHandler handler = PropertyChanged;
		if (handler != null)
		{
			handler(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}