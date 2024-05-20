using DTOsHS;

namespace PLWinFormHS
{
    public partial class UpdatePlayerForm : Form
    {
        private int playerId;
        public Form1.UpdatePlayerDelegate UpdatePlayer = delegate { };

        public UpdatePlayerForm(PlayerDetail playerDetail,bool isDetailForm = false)
        {
            InitializeComponent();

            firstNameInput.Text = playerDetail.FName;
            lastNameInput.Text = playerDetail.LName;
            birthDayInput.Value = playerDetail.BirthDay.ToDateTime(TimeOnly.MaxValue);
            notesInput.Text = playerDetail.Notes;
            playerId = playerDetail.PlayerId;

            if(isDetailForm)
                addPlayerButton.Visible = false;
        }

        private void addPlayerButton_Click(object sender, EventArgs e)
        {
            UpdatePlayer(new PlayerDetail
            {
                FName = firstNameInput.Text,
                LName = lastNameInput.Text,
                BirthDay = DateOnly.FromDateTime(birthDayInput.Value.Date),
                Notes = notesInput.Text,
                PlayerId = playerId,
            });

            this.Close();
        }
    }
}
