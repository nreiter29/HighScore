namespace DTOsHS
{
    public class GameIndex
    {
        public int GameId { get; set; }
        public string Publisher { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public DateOnly ReleaseDate { get; set; }
    }
}
