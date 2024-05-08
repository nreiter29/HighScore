using DALHS;
using DTOsHS;
using ModelsHS;

namespace BLHS.Repos
{
    public class PlayerRepo: IPlayerRepo
    {
        IDal? _dal;

        public PlayerRepo(IDal dal)
        {
            _dal = dal;
        }

        public List<PlayerIndex> GetPlayers()
        {
            throw new NotImplementedException();
        }

        public List<SelectItem> GetPlayerSelect()
        {
            throw new NotImplementedException();
        }

        public PlayerDetail GetPlayer(int gameId)
        {
            throw new NotImplementedException();
        }

        public List<PlayerIndex> GetPlayersByGame(int playerId)
        {
            throw new NotImplementedException();
        }

        public bool Add(PlayerAdd playerDetail)
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
