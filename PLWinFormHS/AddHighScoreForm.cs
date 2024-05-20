using DTOsHS;
using ModelsHS;

namespace PLWinFormHS
{
    public partial class AddHighScoreForm : Form
    {
        private List<PlayerIndex> players;
        private List<GameIndex> games;

        public AddHighScoreForm(List<GameIndex> gameIndexDataSource, List<PlayerIndex> playerIndexDataSource)
        {
            InitializeComponent();

            players = playerIndexDataSource;
            games = gameIndexDataSource;

            playerIndexBindingSource.DataSource = playerIndexDataSource.Select(player => player.FullName);
            gameIndexBindingSource.DataSource = gameIndexDataSource.Select(game => game.Title);
        }

        public Form1.AddHighScoreDelegate AddHighScore = delegate { };

        private void addHighScoreButton_Click(object sender, EventArgs e)
        {
            var player = players.Find(player => player.FullName == (string)playerIndexBindingSource.Current);
            var game = games.Find(game => game.Title == (string)gameIndexBindingSource.Current);

            AddHighScore(new HighScore
            {
                PlayerId = player!.PlayerId,
                GameId = game!.GameId,
                Score = Decimal.ToInt32(scoreInput.Value),
                Created = DateTime.Now,
                Publisher = game.Publisher,
                FullName = player.FullName,
            });

            this.Close();
        }
    }
}
