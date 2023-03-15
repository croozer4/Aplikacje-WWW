﻿namespace AWWW_lab1_gr1_Kulesza.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public DateTime FoundingDate { get; set; }
        public List<Match> Matches { get; set; }
        public League League { get; set; }
        public List<Player> Players { get; set; }
    }
}