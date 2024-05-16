using DTOsHS;

namespace PLWinFormHS
{
    public partial class AddPlayerForm : Form
    {
        public AddPlayerForm()
        {
            InitializeComponent();
        }

        public Form1.AddPlayerDelegate AddPlayer = delegate { };

        private void addPlayerButton_Click(object sender, EventArgs e)
        {

            AddPlayer(new PlayerAdd
            {
                FName = firstNameInput.Text,
                LName = lastNameInput.Text,
                BirthDay = DateOnly.FromDateTime(birthDayInput.Value.Date),
                Notes = notesInput.Text,
                Entry = DateTime.Now,
                Pw = passwordInput.Text,
            });

            this.Close();
        }
    }
}
