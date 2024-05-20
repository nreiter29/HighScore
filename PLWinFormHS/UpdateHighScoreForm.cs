using DTOsHS;
using ModelsHS;

namespace PLWinFormHS
{
    public partial class UpdateHighScoreForm : Form
    {
        private List<PlayerIndex> players;
        private List<GameIndex> games;
        private HighScorePlayerIndex? highScorePlayerIndex;
        private HighScoreGameIndex? highScoreGameIndex;

        public Form1.UpdateHighScoreDelegate UpdateHighScore = delegate { };

        public UpdateHighScoreForm(List<GameIndex> gameIndexDataSource, List<PlayerIndex> playerIndexDataSource, HighScorePlayerIndex? highScorePlayerIndex, HighScoreGameIndex? highScoreGameIndex)
        {
            InitializeComponent();

            players = playerIndexDataSource;
            games = gameIndexDataSource;
            this.highScorePlayerIndex = highScorePlayerIndex;
            this.highScoreGameIndex = highScoreGameIndex;

            playerIndexBindingSource.DataSource = playerIndexDataSource.Select(player => player.FullName);
            gameIndexBindingSource.DataSource = gameIndexDataSource.Select(game => game.Title);

            if (highScorePlayerIndex != null)
                scoreInput.Value = highScorePlayerIndex.Score;

            if (highScoreGameIndex != null)
                scoreInput.Value = highScoreGameIndex.Score;
        }

        private void updateHighScoreButton_Click(object sender, EventArgs e)
        {
            var player = players.Find(player => player.FullName == (string)playerIndexBindingSource.Current);
            var game = games.Find(game => game.Title == (string)gameIndexBindingSource.Current);

            if (highScorePlayerIndex != null)
                UpdateHighScore(new HighScore
                {
                    PlayerId = player!.PlayerId,
                    GameId = game!.GameId,
                    Score = Decimal.ToInt32(scoreInput.Value),
                    Publisher = game.Publisher,
                    Created = highScorePlayerIndex.Created,
                });

            if (highScoreGameIndex != null)
                UpdateHighScore(new HighScore
                {
                    PlayerId = player!.PlayerId,
                    GameId = game!.GameId,
                    Score = Decimal.ToInt32(scoreInput.Value),
                    Publisher = game.Publisher,
                    Created = highScoreGameIndex.Created,
                });

            this.Close();
        }
    }
}
