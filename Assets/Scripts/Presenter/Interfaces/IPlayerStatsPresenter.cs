using System;
using System.Collections.Generic;

namespace OtusUnityHomework.Presenter
{
    public interface IPlayerStatsPresenter
    {
        List<ICharacterStatPresenter> GetStats();
        
        event Action OnStatsUpdated;
    }
}