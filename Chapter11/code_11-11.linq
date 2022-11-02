<Query Kind="Statements" />

var allGames = new[] { (Date: DateTime.Now, PlayerName: "12", Score: 1), (Date: DateTime.Now, PlayerName: "12", Score: 1) };

void DisplayHighScoreForDate(DateTime date)
{
	var filteredGames = allGames.Where(game => game.Date == date);
	string highestPlayer = null;
	int highestScore = -1;
	foreach (var game in filteredGames)
	{
		if (game.Score > highestScore)
		{
			highestPlayer = game.PlayerName;
			highestScore = game.Score;
		}
	}
	Console.WriteLine(highestPlayer == null
		? "No games played"
		: $"Highest score was {highestScore} by {highestPlayer}");
}