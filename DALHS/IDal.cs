namespace DALHS
{
    public interface IDal
    {
        List<Game> Games { get; }
        List<Player> Players { get; }
        List<HighScore> HighScores { get; }
        public string FilePath { get; set; }
        int Save();
        void Rollback();

        #region Events

        /// <summary>
        /// When Players are loaded
        /// </summary>
        public event EventHandler<string>? PlayersLoaded;

        /// <summary>
        /// When Players are saved
        /// </summary>
        public event EventHandler<string>? PlayerSaved;

        /// <summary>
        /// When Games are loaded
        /// </summary>
        public event EventHandler<string>? GamesLoaded;

        /// <summary>
        /// When Games are saved
        /// </summary>
        public event EventHandler<string>? GameSaved;

        /// <summary>
        /// When HighScores are loaded
        /// </summary>
        public event EventHandler<string>? HighScoresLoaded;

        /// <summary>
        /// When HighScores are saved
        /// </summary>
        public event EventHandler<string>? HighScoreSaved;

        #endregion

    }
}
