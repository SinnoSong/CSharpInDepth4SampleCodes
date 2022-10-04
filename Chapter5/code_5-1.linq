<Query Kind="Program">
  <Namespace>System.Windows.Forms</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

void Main()
{
	//var form = new AsyncIntro();
	//form.Show();
	
	Application.Run(new AsyncIntro());
}

public class AsyncIntro : Form
{
	private static readonly HttpClient client = new HttpClient();
	private readonly Label label;
	private readonly Button button;

	public AsyncIntro()
	{
		label = new Label
		{
			Location = new System.Drawing.Point(10, 20),
			Text = "Length"
		};
		button = new Button
		{
			Location = new System.Drawing.Point(10, 50),
			Text = "Click"
		};
		button.Click += DisplayWebSiteLength;
		AutoSize = true;
		Controls.Add(label);
		Controls.Add(button);
	}

	async void DisplayWebSiteLength(object sender, EventArgs e)
	{
		label.Text = "Fetching...";
		string text = await client.GetStringAsync("http://csharpindepth.com");
		label.Text = text.Length.ToString();
	}
}