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

        public List<HighScoreIndex> GetHighScores()
        {
            var highScores = from h in _dal.HighScores
                select new HighScoreIndex
                {
                    PlayerId = h.PlayerId,
                    Score = h.Score,
                    Created = h.Created,
                    GameId = h.GameId,
                    Publisher = h.Publisher,
                };
            return highScores.ToList();
        }

        public List<HighScoreGameIndex> GetHighScoresByGame(int gameId)
        {
            var highScores = from h in _dal.HighScores
                where h.GameId == gameId
                select new HighScoreGameIndex
                {
                    Score = h.Score,
                    Created = h.Created,
                    GameId = h.GameId,
                    Publisher = h.Publisher,
                    FullName = h.FullName,
                };
            return highScores.ToList();
        }

        public List<HighScorePlayerIndex> GetHighScoresByPlayer(int playerId)
        {
            var highScores = from h in _dal.HighScores
                where h.PlayerId == playerId
                select new HighScorePlayerIndex()
                {
                    PlayerId = h.PlayerId,
                    Score = h.Score,
                    Created = h.Created,
                    GameId = h.GameId,
                };
            return highScores.ToList();
        }

        public bool Add(HighScore highScore)
        {
            HighScore newHighScore = new HighScore
            {
                PlayerId = highScore.PlayerId,
                GameId = highScore.GameId,
                Score = highScore.Score,
                Created = DateTime.Now,
                Publisher = highScore.Publisher,
                FullName = highScore.FullName,
            };
            _dal.HighScores.Add(newHighScore);
            return true;
        }

        public bool Update(HighScore highScore)
        {
            var highScoreToUpdate =
                _dal.HighScores.Find(h => h.GameId == highScore.GameId && h.PlayerId == highScore.PlayerId);

            if (highScoreToUpdate is null)
                return false;

            highScoreToUpdate.Score = highScore.Score;
            highScoreToUpdate.Created = highScore.Created;
            highScoreToUpdate.PlayerId = highScore.PlayerId;
            highScoreToUpdate.GameId = highScore.GameId;
            highScoreToUpdate.Publisher = highScore.Publisher;
            highScoreToUpdate.FullName = highScore.FullName;
            return true;
        }

        public bool Delete(int gameId, int playerId)
        {
            var highScoreToDelete = _dal.HighScores.Find(h => h.GameId == gameId && h.PlayerId == playerId);
            if (highScoreToDelete is null)
                return false;

            _dal.HighScores.Remove(highScoreToDelete);
            return true;
        }

        public bool Delete(HighScore highScore)
        {
            return _dal.HighScores.Remove(highScore);
        }
    }
}
