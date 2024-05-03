namespace ModelsHS
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public DateOnly BirthDay { get; set; }
        public string PWHash { get; set; }
        public DateTime Entry { get; set; }
        public DateTime Exit { get; set; }
        public string Notes { get; set; }

        public string FullName
        {
            get { return LName + " " + FName; }
        }
    }
}
