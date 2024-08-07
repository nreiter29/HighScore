﻿namespace ModelsHS
{
    public class Player : Details
    {
        public int PlayerId { get; set; }
        public string FName { get; set; } = string.Empty;
        public string LName { get; set; } = string.Empty;
        public DateOnly BirthDay { get; set; }
        public string PwHash { get; set; } = string.Empty;

        public string FullName
        {
            get { return LName + " " + FName; }
        }
    }
}
