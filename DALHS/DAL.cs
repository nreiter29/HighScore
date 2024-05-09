namespace DALHS
{
    public abstract class DAL : IDal
    {
        protected List<Game>? _games;
        protected List<Player>? _players;
        protected List<HighScore>? _highScores;

        public List<Game> Games => _games ??= LoadGames();
        public List<Player> Players => _players ??= LoadPlayers();
        public List<HighScore> HighScores => _highScores ??= LoadHighScores();

        public string FilePath { get; set; } = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public abstract int Save();

        public void Rollback()
        {
            _players = null;
            _games = null;
            _highScores = null;
        }

        protected abstract List<Game> LoadGames();
        protected abstract List<Player> LoadPlayers();
        protected abstract List<HighScore> LoadHighScores();
        public event EventHandler<string>? PlayersLoaded;
        public event EventHandler<string>? PlayerSaved;
        public event EventHandler<string>? GamesLoaded;
        public event EventHandler<string>? GameSaved;
        public event EventHandler<string>? HighScoresLoaded;
        public event EventHandler<string>? HighScoreSaved;
    }
}
