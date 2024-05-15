using BLHS;
using DTOsHS;

namespace PLWinFormHS
{
    public partial class Form1 : Form
    {
        UnitOfWork unitOfWork = new UnitOfWork(DalType.json);

        public Form1()
        {
            InitializeComponent();

            playerIndexBindingSource.DataSource = unitOfWork.Players.GetPlayers();
            gameIndexBindingSource.DataSource = unitOfWork.Games.GetGames();
            highScoreIndexBindingSource.DataSource = unitOfWork.HIghScores.GetHighscoresByPlayer(unitOfWork.Players.GetPlayers()[0].PlayerId);
            highScoreGameIndexBindingSource.DataSource = unitOfWork.HIghScores.GetHighscoresByGame(unitOfWork.Games.GetGames()[0].GameId);
            playerIndexBindingSource.CurrentChanged += playerIndexBindingSource_CurrentChanged;
            gameIndexBindingSource.CurrentChanged += highScoreGameIndexBindingSource_CurrentChanged;
        }

        private void ReloadPlayers()
        {
            playerIndexBindingSource.CurrentChanged -= playerIndexBindingSource_CurrentChanged;
            playerIndexBindingSource.DataSource = unitOfWork.Players.GetPlayers();
            playerIndexBindingSource.CurrentChanged += playerIndexBindingSource_CurrentChanged;
        }

        private void ReloadGames()
        {
            gameIndexBindingSource.CurrentChanged -= highScoreGameIndexBindingSource_CurrentChanged;
            gameIndexBindingSource.DataSource = unitOfWork.Games.GetGames();
            gameIndexBindingSource.CurrentChanged += highScoreGameIndexBindingSource_CurrentChanged;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            unitOfWork.Commit();
        }

        private void playerIndexBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var currentPlayer = (PlayerIndex)playerIndexBindingSource.Current;
            highScoreIndexBindingSource.DataSource = unitOfWork.HIghScores.GetHighscoresByPlayer(currentPlayer.PlayerId);
        }

        private void highScoreGameIndexBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var currentGame = (GameIndex)gameIndexBindingSource.Current;
            highScoreGameIndexBindingSource.DataSource = unitOfWork.HIghScores.GetHighscoresByGame(currentGame.GameId);
        }

        private void rollbackButton_Click(object sender, EventArgs e)
        {
            unitOfWork.Rollback();
        }

        public delegate void AddPlayerDelegate(PlayerAdd playerAdd);

        private void AddPlayer(PlayerAdd player)
        {
            unitOfWork.Players.Add(player);
        }

        private void addPlayerButton_Click(object sender, EventArgs e)
        {
            AddPlayerForm addPlayerForm = new AddPlayerForm();
            addPlayerForm.AddPlayer = new AddPlayerDelegate(this.AddPlayer);
            addPlayerForm.ShowDialog();

            ReloadPlayers();
        }

        private void deletePlayerButton_Click(object sender, EventArgs e)
        {
            var currentPlayer = (PlayerIndex)playerIndexBindingSource.Current;
            var sureResult = MessageBox.Show($"Are u sure u wan't do delete {currentPlayer.FullName}?");

            if (sureResult == DialogResult.OK)
                unitOfWork.Players.Delete(currentPlayer.PlayerId);

            ReloadPlayers();
        }

        public delegate void AddGameDelegate(GameDetail gameDetail);

        private void AddGame(GameDetail gameDetail)
        {
            unitOfWork.Games.Add(gameDetail);
        }

        private void addGameButton_Click(object sender, EventArgs e)
        {
            AddGameForm addGameForm = new AddGameForm();
            addGameForm.AddGame = new AddGameDelegate(this.AddGame);
            addGameForm.ShowDialog();

            if(addGameForm.Added)
                addGameForm.Close();

            ReloadGames();
        }

        private void deleteGameButton_Click(object sender, EventArgs e)
        {
            var currentGame = (GameIndex)gameIndexBindingSource.Current;
            var sureResult = MessageBox.Show($"Are u sure u wan't do delete {currentGame.Title}?");

            if (sureResult == DialogResult.OK)
                unitOfWork.Games.Delete(currentGame.GameId);

            ReloadGames();
        }
    }
}
