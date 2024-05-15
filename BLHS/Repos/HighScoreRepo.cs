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
                    Created = h.Created
                };
            return highscores.ToList();
        }

        public List<HighScoreIndex> GetHighscoresByGame(int gameId)
        {
            var highscores = from h in _dal.HighScores
                where h.GameId == gameId
                select new HighScoreIndex
                {
                    PlayerId = h.PlayerId,
                    Score = h.Score,
                    Created = h.Created
                };
            return highscores.ToList();
        }

        public List<HighScoreIndex> GetHighscoresByPlayer(int playerId)
        {
            var highscores = from h in _dal.HighScores
                where h.PlayerId == playerId
                select new HighScoreIndex
                {
                    PlayerId = h.PlayerId,
                    Score = h.Score,
                    Created = h.Created
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
                Created = DateTime.Now
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
