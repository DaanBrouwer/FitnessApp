﻿namespace API.Entities
{
    public class Photo
    {
        public int Id { get; set; }
        public string Url { get; set; }

        public Exercises Exercises { get; set; }
    }
}