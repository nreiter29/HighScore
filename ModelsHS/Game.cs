﻿namespace ModelsHS
{
    public class Game : Details
    {
        public int GameId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Publisher { get; set; } = string.Empty;
        public DateOnly ReleaseDate { get; set; }
    }
}
