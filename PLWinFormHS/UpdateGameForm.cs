using DTOsHS;

namespace PLWinFormHS
{
    public partial class UpdateGameForm : Form
    {
        private int gameId;
        public Form1.UpdateGameDelegate UpdateGame = delegate { };
        public UpdateGameForm(GameDetail gameDetail)
        {
            InitializeComponent();

            titleInput.Text = gameDetail.Title;
            publisherInput.Text = gameDetail.Publisher;
            releaseDateInput.Value = gameDetail.ReleaseDate.ToDateTime(TimeOnly.MaxValue);
            notesInput.Text = gameDetail.Notes;
            gameId = gameDetail.GameId; 
        }

        private void updateGameButton_Click(object sender, EventArgs e)
        {
            UpdateGame(new GameDetail
            {
                Title = titleInput.Text,
                Publisher = publisherInput.Text,
                ReleaseDate = DateOnly.FromDateTime(releaseDateInput.Value.Date),
                Notes = notesInput.Text,
                GameId = gameId,
            });

            this.Close();
        }
    }
}
