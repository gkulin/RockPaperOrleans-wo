﻿namespace RockPaperOrleans.Abstractions
{
    [Serializable]
    public class Turn
    {
        public List<Throw> Throws { get; set; } = new();
    }
}
