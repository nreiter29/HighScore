using BLHS;
using DTOsHS;
using ModelsHS;

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
            highScoreIndexBindingSource.DataSource = unitOfWork.HIghScores.GetHighScoresByPlayer(unitOfWork.Players.GetPlayers()[0].PlayerId);
            highScoreGameIndexBindingSource.DataSource = unitOfWork.HIghScores.GetHighScoresByGame(unitOfWork.Games.GetGames()[0].GameId);
            playerIndexBindingSource.CurrentChanged += playerIndexBindingSource_CurrentChanged!;
            gameIndexBindingSource.CurrentChanged += highScoreGameIndexBindingSource_CurrentChanged!;
        }

        private void ReloadPlayers()
        {
            playerIndexBindingSource.CurrentChanged -= playerIndexBindingSource_CurrentChanged!;
            playerIndexBindingSource.DataSource = unitOfWork.Players.GetPlayers();
            playerIndexBindingSource.CurrentChanged += playerIndexBindingSource_CurrentChanged!;

            var currentPlayer = (PlayerIndex)playerIndexBindingSource.Current;
            highScoreIndexBindingSource.DataSource = unitOfWork.HIghScores.GetHighScoresByPlayer(currentPlayer.PlayerId);
        }

        private void ReloadGames()
        {
            gameIndexBindingSource.CurrentChanged -= highScoreGameIndexBindingSource_CurrentChanged!;
            gameIndexBindingSource.DataSource = unitOfWork.Games.GetGames();
            gameIndexBindingSource.CurrentChanged += highScoreGameIndexBindingSource_CurrentChanged!;

            var currentGame = (GameIndex)gameIndexBindingSource.Current;
            highScoreGameIndexBindingSource.DataSource = unitOfWork.HIghScores.GetHighScoresByGame(currentGame.GameId);

        }

        private void ReloadAll()
        {
            playerIndexBindingSource.CurrentChanged -= playerIndexBindingSource_CurrentChanged!;
            playerIndexBindingSource.DataSource = unitOfWork.Players.GetPlayers();
            playerIndexBindingSource.CurrentChanged += playerIndexBindingSource_CurrentChanged!;

            gameIndexBindingSource.CurrentChanged -= highScoreGameIndexBindingSource_CurrentChanged!;
            gameIndexBindingSource.DataSource = unitOfWork.Games.GetGames();
            gameIndexBindingSource.CurrentChanged += highScoreGameIndexBindingSource_CurrentChanged!;

            highScoreIndexBindingSource.DataSource = unitOfWork.HIghScores.GetHighScoresByPlayer(unitOfWork.Players.GetPlayers()[0].PlayerId);
            highScoreGameIndexBindingSource.DataSource = unitOfWork.HIghScores.GetHighScoresByGame(unitOfWork.Games.GetGames()[0].GameId);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            unitOfWork.Commit();
        }

        private void playerIndexBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var currentPlayer = (PlayerIndex)playerIndexBindingSource.Current;
            highScoreIndexBindingSource.DataSource = unitOfWork.HIghScores.GetHighScoresByPlayer(currentPlayer.PlayerId);
        }

        private void highScoreGameIndexBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var currentGame = (GameIndex)gameIndexBindingSource.Current;
            highScoreGameIndexBindingSource.DataSource = unitOfWork.HIghScores.GetHighScoresByGame(currentGame.GameId);
        }

        private void rollbackButton_Click(object sender, EventArgs e)
        {
            var sureResult = MessageBox.Show($@"Are u sure u want do rollback?");

            if (sureResult == DialogResult.OK)
            {
                unitOfWork.Rollback();
                ReloadAll();
            }
        }

        public delegate void AddPlayerDelegate(PlayerAdd playerAdd);

        private void AddPlayer(PlayerAdd player)
        {
            if (unitOfWork.Players.Add(player))
                MessageBox.Show($@"Added Successfully {player.FName} {player.LName}");
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
            var sureResult = MessageBox.Show($@"Are u sure u want do delete {currentPlayer.FullName}?");

            if (sureResult == DialogResult.OK)
                unitOfWork.Players.Delete(currentPlayer.PlayerId);

            ReloadPlayers();
        }

        public delegate void AddGameDelegate(GameDetail gameDetail);

        private void AddGame(GameDetail gameDetail)
        {
            if (unitOfWork.Games.Add(gameDetail))
                MessageBox.Show($@"Added Successfully {gameDetail.Title}");
        }

        private void addGameButton_Click(object sender, EventArgs e)
        {
            AddGameForm addGameForm = new AddGameForm();
            addGameForm.AddGame = new AddGameDelegate(this.AddGame);
            addGameForm.ShowDialog();

            ReloadGames();
        }

        private void deleteGameButton_Click(object sender, EventArgs e)
        {
            var currentGame = (GameIndex)gameIndexBindingSource.Current;
            var sureResult = MessageBox.Show($@"Are u sure u want do delete {currentGame.Title}?");

            if (sureResult == DialogResult.OK)
                unitOfWork.Games.Delete(currentGame.GameId);

            ReloadGames();
        }

        public delegate void AddHighScoreDelegate(HighScore highScore);

        private void AddHighScore(HighScore highScore)
        {
            if (unitOfWork.HIghScores.Add(highScore))
                MessageBox.Show($@"Added Successfully new HighScore");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddHighScoreForm addHighScoreForm = new AddHighScoreForm(unitOfWork.Games.GetGames(), unitOfWork.Players.GetPlayers());
            addHighScoreForm.AddHighScore = new AddHighScoreDelegate(this.AddHighScore);
            addHighScoreForm.ShowDialog();

            ReloadAll();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var currentHighScore = (HighScorePlayerIndex)highScoreIndexBindingSource.Current;

            var sureResult = MessageBox.Show($@"Are u sure u want do delete HighScore {currentHighScore.Score} from {currentHighScore.Created}?");
            if (sureResult == DialogResult.OK)
                unitOfWork.HIghScores.Delete(currentHighScore.GameId, currentHighScore.PlayerId);

            ReloadAll();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddHighScoreForm addHighScoreForm = new AddHighScoreForm(unitOfWork.Games.GetGames(), unitOfWork.Players.GetPlayers());
            addHighScoreForm.AddHighScore = new AddHighScoreDelegate(this.AddHighScore);
            addHighScoreForm.ShowDialog();

            ReloadAll();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var currentHighScore = (HighScorePlayerIndex)highScoreIndexBindingSource.Current;

            var sureResult = MessageBox.Show($@"Are u sure u want do delete HighScore {currentHighScore.Score} from {currentHighScore.Created}?");
            if (sureResult == DialogResult.OK)
                unitOfWork.HIghScores.Delete(currentHighScore.GameId, currentHighScore.PlayerId);

            ReloadAll();
        }

        public delegate void UpdatePlayerDelegate(PlayerDetail playerDetail);

        private void UpdatePlayer(PlayerDetail playerDetail)
        {
            if (unitOfWork.Players.Update(playerDetail))
                MessageBox.Show($@"Updated Successfully {playerDetail.FName} {playerDetail.LName}");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var currentPlayer = (PlayerIndex)playerIndexBindingSource.Current;

            UpdatePlayerForm updateForm = new UpdatePlayerForm(unitOfWork.Players.GetPlayer(currentPlayer.PlayerId));
            updateForm.UpdatePlayer = new UpdatePlayerDelegate(this.UpdatePlayer);
            updateForm.ShowDialog();

            ReloadPlayers();
        }

        public delegate void UpdateGameDelegate(GameDetail gameDetail);

        private void UpdateGame(GameDetail gameDetail)
        {
            if (unitOfWork.Games.Update(gameDetail))
                MessageBox.Show($@"Updated Successfully {gameDetail.Title}");
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var currentGame = (GameIndex)gameIndexBindingSource.Current;

            UpdateGameForm updateForm = new UpdateGameForm(unitOfWork.Games.GetGame(currentGame.GameId));
            updateForm.UpdateGame = new UpdateGameDelegate(this.UpdateGame);
            updateForm.ShowDialog();

            ReloadGames();
        }

        public delegate void UpdateHighScoreDelegate(HighScore highScore);

        private void UpdateHighScore(HighScore highScore)
        {
            if (unitOfWork.HIghScores.Update(highScore))
                MessageBox.Show($@"Updated Successfully HighScore");
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var currentHighScore = (HighScorePlayerIndex)highScoreIndexBindingSource.Current;

            UpdateHighScoreForm updateForm = new UpdateHighScoreForm(unitOfWork.Games.GetGames(), unitOfWork.Players.GetPlayers(), currentHighScore, null);
            updateForm.UpdateHighScore = new UpdateHighScoreDelegate(this.UpdateHighScore);
            updateForm.ShowDialog();

            ReloadAll();
        }

        private void dataGridView4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var currentHighScore = (HighScoreGameIndex)highScoreGameIndexBindingSource.Current;

            UpdateHighScoreForm updateForm = new UpdateHighScoreForm(unitOfWork.Games.GetGames(), unitOfWork.Players.GetPlayers(), null, currentHighScore);
            updateForm.UpdateHighScore = new UpdateHighScoreDelegate(this.UpdateHighScore);
            updateForm.ShowDialog();

            ReloadAll();
        }
    }
}
