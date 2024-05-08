using System.Text.Json;

namespace DALHS
{
    public class DalJson : DAL
    {

        public override int Save()
        {
            int count = 0;
            if (_games is not null)
            {
                try
                {
                    using FileStream fileStream = File.Create(FilePath + @"\Games.json");
                    JsonSerializer.Serialize(fileStream, _games);
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
                    using FileStream fileStream = File.Create(FilePath + @"\Players.json");
                    JsonSerializer.Serialize(fileStream, _players);
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
                    using FileStream fileStream = File.Create(FilePath + @"\HighScores.json");
                    JsonSerializer.Serialize(fileStream, _highScores);
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
            List<Game>? game;
            try
            {
                string jsonString = File.ReadAllText(FilePath + @"\Games.json");
                game = JsonSerializer.Deserialize<List<Game>>(jsonString);
            }
            catch
            {
                game = new List<Game>();
            }

            return game;
        }

        protected override List<Player> LoadPlayers()
        {
            List<Player>? player;
            try
            {
                string jsonString = File.ReadAllText(FilePath + @"\Players.json");
                player = JsonSerializer.Deserialize<List<Player>>(jsonString);
            }
            catch
            {
                player = new List<Player>();
            }

            return player;
        }

        protected override List<HighScore> LoadHighScores()
        {
            List<HighScore>? highScore;
            try
            {
                string jsonString = File.ReadAllText(FilePath + @"\HighScores.json");
                highScore = JsonSerializer.Deserialize<List<HighScore>>(jsonString);
            }
            catch
            {
                highScore = new List<HighScore>();
            }

            return highScore;
        }
    }
}
