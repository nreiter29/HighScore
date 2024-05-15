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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public bool Update(GameDetail gameDetail)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int gameId)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Game game)
        {
            throw new NotImplementedException();
        }
    }
}
