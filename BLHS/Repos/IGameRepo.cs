using DTOsHS;
using ModelsHS;

namespace BLHS.Repos
{
    public interface IGameRepo
    {
        List<GameIndex> GetGames();
        List<SelectItem> GetGameSelect();
        GameDetail GetGame(int gameId);
        List<GameIndex> GetGamesByPlayer(int playerId);

        bool Add(GameDetail gameDetail);
        bool Update(GameDetail gameDetail);
        bool Delete(int gameId);
        bool Delete(Game game);
    }
}
