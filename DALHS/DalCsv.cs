namespace DALHS
{
    public class DalCsv : DAL
    {

        public override int Save()
        {
            int count = 0;
            if (_games is not null)
            {
                try
                {
                    using StreamWriter file = new(FilePath + @"\Games.csv");
                    foreach (var game in _games)
                    {
                        file.WriteLine(
                            $"{game.GameId};{game.Title};{game.Publisher};{game.ReleaseDate};{game.Entry};{game.Exit};{game.ModifiedBy};{game.LastModified};{game.Notes}");
                    }

                    count += _games.Count;
                }
                catch (Exception ex)
                {
                    return 0;
                }
            }

            if (_players is not null)
            {
                try
                {
                    using StreamWriter file = new(FilePath + @"\Players.csv");
                    foreach (var player in _players)
                    {
                        file.WriteLine(
                            $"{player.PlayerId};{player.FName};{player.LName};{player.FullName};{player.Entry};{player.Exit};{player.ModifiedBy};{player.LastModified};{player.Notes}");
                    }

                    count += _players.Count;
                }
                catch (Exception ex)
                {
                    return 0;
                }
            }
            
            if (_highScores is not null)
            {
                try
                {
                    using StreamWriter file = new(FilePath + @"\Highscores.csv");
                    foreach (var highScore in _highScores)
                    {
                        file.WriteLine(
                            $"{highScore.PlayerId};{highScore.GameId};{highScore.Score};{highScore.Created}");
                    }

                    count += _highScores.Count;
                }
                catch (Exception ex)
                {
                    return 0;
                }
            }

            return count;
        }

        protected override List<Game> LoadGames()
        {
            throw new NotImplementedException();
        }

        protected override List<Player> LoadPlayers()
        {
            throw new NotImplementedException();
        }

        protected override List<HighScore> LoadHighScores()
        {
            throw new NotImplementedException();
        }
    }
}
