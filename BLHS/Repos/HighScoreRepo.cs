using DALHS;
using DTOsHS;
using ModelsHS;

namespace BLHS.Repos
{
    public class HighScoreRepo
    {
        IDal _dal;

        public HighScoreRepo(IDal dal)
        {
            _dal = dal;
        }

        public List<HighScoreIndex> GetHighscores()
        {
            var highscores = from h in _dal.HighScores
                select new HighScoreIndex
                {
                    PlayerId = h.PlayerId,
                    Score = h.Score,
                    Created = h.Created,
                    GameId = h.GameId,
                    Publisher = h.Publisher,
                };
            return highscores.ToList();
        }

        public List<HighScoreGameIndex> GetHighscoresByGame(int gameId)
        {
            var highscores = from h in _dal.HighScores
                where h.GameId == gameId
                select new HighScoreGameIndex
                {
                    Score = h.Score,
                    Created = h.Created,
                    GameId = h.GameId,
                    Publisher = h.Publisher,
                };
            return highscores.ToList();
        }

        public List<HighScorePlayerIndex> GetHighscoresByPlayer(int playerId)
        {
            var highscores = from h in _dal.HighScores
                where h.PlayerId == playerId
                select new HighScorePlayerIndex()
                {
                    PlayerId = h.PlayerId,
                    Score = h.Score,
                    Created = h.Created,
                    GameId = h.GameId,
                };
            return highscores.ToList();
        }

        public bool Add(HighScore highscore)
        {
            HighScore newHighscore = new HighScore
            {
                PlayerId = highscore.PlayerId,
                GameId = highscore.GameId,
                Score = highscore.Score,
                Created = DateTime.Now,
                Publisher = highscore.Publisher,
            };
            _dal.HighScores.Add(newHighscore);
            return true;
        }

        public bool Update(HighScore highscore)
        {
            var highscoreToUpdate =
                _dal.HighScores.Find(h => h.GameId == highscore.GameId && h.PlayerId == highscore.PlayerId);

            if (highscoreToUpdate is null)
                return false;

            highscoreToUpdate.Score = highscore.Score;
            highscoreToUpdate.Created = highscore.Created;
            return true;
        }

        public bool Delete(int gameId, int playerId)
        {
            var highscoreToDelete = _dal.HighScores.Find(h => h.GameId == gameId && h.PlayerId == playerId);
            if (highscoreToDelete is null)
                return false;

            _dal.HighScores.Remove(highscoreToDelete);
            return true;
        }

        public bool Delete(HighScore highscore)
        {
            return _dal.HighScores.Remove(highscore);
        }
    }
}
