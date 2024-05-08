using System.Xml.Serialization;

namespace DALHS
{
    public class DalXml : DAL
    {

        public override int Save()
        {
            int count = 0;
            if (_games is not null)
            {
                try
                {
                    using FileStream fileStream = File.Create(FilePath + @"\Games.xml");
                    var xmlSerializer = new XmlSerializer(typeof(List<Game>));
                    xmlSerializer.Serialize(fileStream, _games);
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
                    using FileStream fileStream = File.Create(FilePath + @"\Players.xml");
                    var xmlSerializer = new XmlSerializer(typeof(List<Player>));
                    xmlSerializer.Serialize(fileStream, _players);
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
                    var xmlSerializer = new XmlSerializer(typeof(List<HighScore>));
                    xmlSerializer.Serialize(fileStream, _highScores);
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
                var xmlSerializer = new XmlSerializer(typeof(List<Game>));
                using var myFileStream = new FileStream(FilePath + @"\Games.xml", FileMode.Open);
                game = (List<Game>)xmlSerializer.Deserialize(myFileStream);
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
                var xmlSerializer = new XmlSerializer(typeof(List<Player>));
                using var myFileStream = new FileStream(FilePath + @"\Players.xml", FileMode.Open);
                player = (List<Player>)xmlSerializer.Deserialize(myFileStream);
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
                var xmlSerializer = new XmlSerializer(typeof(List<HighScore>));
                using var myFileStream = new FileStream(FilePath + @"\HighScores.xml", FileMode.Open);
                highScore = (List<HighScore>)xmlSerializer.Deserialize(myFileStream);
            }
            catch
            {
                highScore = new List<HighScore>();
            }

            return highScore;
        }
    }
}
