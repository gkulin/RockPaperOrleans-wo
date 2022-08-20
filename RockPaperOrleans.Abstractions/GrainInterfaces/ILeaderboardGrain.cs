﻿using Orleans;

namespace RockPaperOrleans.Abstractions
{
    public interface ILeaderboardGrain : IGrainWithGuidKey
    {
        Task GameStarted(Game game);
        Task TurnStarted(Turn turn, Game game);
        Task TurnCompleted(Turn turn, Game game);
        Task GameCompleted(Game game);
        Task Subscribe(ILeaderboardGrainObserver observer);
        Task UnSubscribe(ILeaderboardGrainObserver observer);
    }
}