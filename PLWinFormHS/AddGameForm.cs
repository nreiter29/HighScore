using DTOsHS;

namespace PLWinFormHS
{
    public partial class AddGameForm : Form
    {
        public AddGameForm()
        {
            InitializeComponent();
        }

        public Form1.AddGameDelegate AddGame = delegate { };

        private void addGameButton_Click(object sender, EventArgs e)
        {
            AddGame(new GameDetail
            {
                Title = titleInput.Text,
                Publisher = publisherInput.Text,
                ReleaseDate = DateOnly.FromDateTime(releaseDateInput.Value.Date),
                Notes = notesInput.Text,
            });

            this.Close();
        }
    }
}
