using DTOsHS;
using ModelsHS;

namespace BLHS.Repos
{
    public interface IHighScoreRepo
    {
        List<HighScoreIndex> GetHighscores();
        List<HighScoreIndex> GetHighscoresByGame(int gameId);
        List<HighScoreIndex> GetHighscoresByPlayer(int playerId);
        bool Add(HighScore highscore);
        bool Update(HighScore highscore);
        bool Delete(int gameId, int playerId);
        bool Delete(HighScore highscore);
    }
}
