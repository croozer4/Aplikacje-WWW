﻿namespace AWWW_lab1_gr1_Kulesza.Models
{
    public class MatchEvent
    {
        public int Id { get; set; }
        public int Minute { get; set; }
        public Match Match { get; set; }
        public MatchPlayer MatchPlayer { get; set; }
        public EventType EventType { get; set; }
    }
}