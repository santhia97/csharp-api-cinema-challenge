﻿namespace api_cinema_challenge.Models
{
    public class MoviePost
    {
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }

        public IEnumerable<ScreeningPost> Screenings { get; set; }
    }
}