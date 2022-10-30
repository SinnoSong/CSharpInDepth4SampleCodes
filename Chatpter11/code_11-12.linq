<Query Kind="Statements" />

var allGames = new[] { (Date: DateTime.Now, PlayerName: "12", Score: 1), (Date: DateTime.Now, PlayerName: "12", Score: 1) };

void DisplayHighScoreForDate(DateTime date)
{
	var filteredGames = allGames.Where(game => game.Date == date);
	(string player, int scoure) highest = (null, -1);
	foreach (var game in filteredGames)
	{
		if (game.Score > highest.scoure)
		{
			highest = (game.PlayerName, game.Score);
		}
	}
	Console.WriteLine(highest.player == null
		? "No games played"
		: $"Highest score was {highest.scoure} by {highest.player}");
}