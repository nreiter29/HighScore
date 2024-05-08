using DTOsHS;
using ModelsHS;

namespace BLHS.Repos
{
    public interface IPlayerRepo
    {
        List<PlayerIndex> GetPlayers();
        List<SelectItem> GetPlayerSelect();
        PlayerDetail GetPlayer(int gameId);
        List<PlayerIndex> GetPlayersByGame(int playerId);
        
        bool Add(PlayerAdd playerDetail);
        bool Update(GameDetail gameDetail);
        bool Delete(int gameId);
        bool Delete(Game game);
    }
}
