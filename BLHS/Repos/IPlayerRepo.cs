using DTOsHS;
using ModelsHS;

namespace BLHS.Repos
{
    public interface IPlayerRepo
    {
        List<PlayerIndex> GetPlayers();
        List<SelectItem> GetPlayerSelect();
        PlayerDetail GetPlayer(int playerId);
        List<PlayerIndex> GetPlayersByGame(int gameId);
        bool Add(PlayerAdd player);
        bool Update(PlayerDetail player);
        bool Delete(int playerId);
        bool Delete(Player player);
    }
}
