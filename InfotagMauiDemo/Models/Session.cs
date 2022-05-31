namespace InfotagMauiDemo.Models
{
    public class Session
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Speaker Speaker { get; set; }

        public TimeOnly Start { get; set; }
        public TimeOnly End { get; set; }

    }
}
