using System;
using System.Collections.Generic;

namespace OtusUnityHomework.Presenter
{
    public interface IPlayerStatsPresenter
    {
        List<string> GetStats();
        
        event Action OnStatsUpdated;
    }
}