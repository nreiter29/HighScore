﻿namespace ModelsHS
{
    public class HighScore
    {
        public int GameId { get; set; }
        public int PlayerId { get; set; }
        public int Score { get; set; }
        public DateTime Created { get; set; }
    }
}
 