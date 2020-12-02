using System;

namespace CodePatternsInlamning
{
    public class DigitalMovie : IDigitalMovie
    {
        public Guid ProductId { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public double Price { get; set; }
        public int DownloadsLeft { get; set; } = 5;
        public int RunTimeInMinutes { get; set; }
        public string Director { get; set; }

        public DigitalMovie(string title, double price, int runTimeInMinutes, string director)
        {
            Title = title;
            RunTimeInMinutes = runTimeInMinutes;
            Director = director;
        }
    }
}