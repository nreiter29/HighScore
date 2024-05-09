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
                            $"{player.PlayerId};{player.FName};{player.LName};{player.Entry};{player.Exit};{player.ModifiedBy};{player.LastModified};{player.Notes}");
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
                    using StreamWriter file = new(FilePath + @"\HighScores.csv");
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
            List<Game>? game = new List<Game>();
            try
            {
                using StreamReader file = new(FilePath + @"\Games.csv");
                string line;
                while ((line = file.ReadLine()) is not null)
                {
                    var parts = line.Split(';', StringSplitOptions.None);
                    game.Add(new Game
                    {
                        GameId = int.Parse(parts[0]),
                        Title = parts[1],
                        Publisher = parts[2],
                        ReleaseDate = DateOnly.Parse(parts[3]),
                        Entry = DateTime.Parse(parts[4]),
                        Exit = DateTime.Parse(parts[5]),
                        ModifiedBy = parts[6],
                        LastModified = DateTime.Parse(parts[7]),
                        Notes = parts[8]
                    });
                }
            }
            catch
            {
                game = new List<Game>();
            }

            return game;
        }

        protected override List<Player> LoadPlayers()
        {
            List<Player>? player = new List<Player>();
            try
            {
                using StreamReader file = new(FilePath + @"\Players.csv");
                string line;
                while ((line = file.ReadLine()) is not null)
                {
                    var parts = line.Split(';', StringSplitOptions.None);
                    player.Add(new Player
                    {
                        PlayerId = int.Parse(parts[0]),
                        FName = parts[1],
                        LName = parts[2],
                        Entry = DateTime.Parse(parts[3]),
                        Exit = DateTime.Parse(parts[4]),
                        ModifiedBy = parts[5],
                        LastModified = DateTime.Parse(parts[6]),
                        Notes = parts[7]
                    });
                }
            }
            catch
            {
                player = new List<Player>();
            }

            return player;  
        }

        protected override List<HighScore> LoadHighScores()
        {
            List<HighScore>? highScore = new List<HighScore>();
            try
            {
                using StreamReader file = new(FilePath + @"\HighScores.csv");
                string line;
                while ((line = file.ReadLine()) is not null)
                {
                    var parts = line.Split(';', StringSplitOptions.None);
                    highScore.Add(new HighScore
                    {
                        PlayerId = int.Parse(parts[0]),
                        GameId = int.Parse(parts[1]),
                        Score = int.Parse(parts[2]),
                        Created = DateTime.Parse(parts[3])
                    });
                }
            }
            catch
            {
                highScore = new List<HighScore>();
            }

            return highScore;
        }
    }
}
