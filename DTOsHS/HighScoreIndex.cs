namespace DTOsHS
{
    public class HighScoreIndex
    {
        public int PlayerId { get; set; }
        public int GameId { get; set; }
        public string Publisher { get; set; } = string.Empty;
        public int Score { get; set; }
        public DateTime Created { get; set; }
    }
}
