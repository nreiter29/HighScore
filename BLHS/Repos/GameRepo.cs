using DALHS;
using DTOsHS;
using ModelsHS;

namespace BLHS.Repos
{
    public class GameRepo : IGameRepo
    {
        IDal _dal;

        public GameRepo(IDal dal)
        {
            this._dal = dal;
        }

        public List<GameIndex> GetGames()
        {
            var games = from g in _dal.Games
                where g.Exit == null || g.Exit < DateTime.Now
                select new GameIndex
                {
                    GameId = g.GameId,
                    ReleaseDate = g.ReleaseDate,
                    Title = g.Title,
                };
            return games.ToList();
        }

        public List<SelectItem> GetGameSelect()
        {
            var games = from g in _dal.Games
                where g.Exit == null || g.Exit > DateTime.Now
                select new SelectItem()
                {
                    ValueMember = g.GameId,
                    DisplayMember = g.Title,
                };

            return games.ToList();
        }

        public GameDetail GetGame(int gameId)
        {
            var games = from g in _dal.Games
                where g.GameId == gameId
                select new GameDetail
                {
                    GameId = g.GameId,
                    Title = g.Title,
                    Publisher = g.Publisher,
                    ReleaseDate = g.ReleaseDate,
                    Notes = g.Notes,
                    Entry = g.Entry,
                    Exit = g.Exit,
                };

            return games.First();
        }

        public List<GameIndex> GetGamesByPlayer(int playerId)
        {
            var games = from g in _dal.Games
                join hs in _dal.HighScores on g.GameId equals hs.GameId
                where hs.PlayerId == playerId
                select new GameIndex
                {
                    GameId = g.GameId,
                    ReleaseDate = g.ReleaseDate,
                    Title = g.Title,
                };

            return games.ToList();
        }

        public bool Add(GameDetail gameDetail)
        {
            try
            {
                Game newGame = new Game()
                {
                    GameId = _dal.Games.Max(g => g.GameId) + 1,
                    Title = gameDetail.Title,
                    ReleaseDate = gameDetail.ReleaseDate,
                    Entry = gameDetail.Entry,
                    Exit = null,
                    Notes = gameDetail.Notes,
                };
                _dal.Games.Add(newGame);
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        public bool Update(GameDetail gameDetail)
        {
            var gameToUpdate = _dal.Games.Find(g => g.GameId == gameDetail.GameId);
            if (gameToUpdate is null)
                return false;

            gameToUpdate.Title = gameDetail.Title;
            gameToUpdate.ReleaseDate = gameDetail.ReleaseDate;
            gameToUpdate.Exit = gameDetail.Exit;
            gameToUpdate.Notes = gameDetail.Notes;

            return true;
        }

        public bool Delete(int gameId)
        {
            var gameToDelete = _dal.Games.Find(g => g.GameId == gameId);
            if (gameToDelete is null)
                return false;

            _dal.Games.Remove(gameToDelete);
            return true;
        }

        public bool Delete(Game game)
        {
            return _dal.Games.Remove(game);
        }
    }
}
