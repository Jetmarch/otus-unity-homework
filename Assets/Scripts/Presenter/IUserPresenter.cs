using UnityEngine;

namespace OtusUnityHomework.Presenter
{
    public interface IUserPresenter
    {
        IUserInfoPresenter UserInfo { get; }
        IPlayerLevelPresenter PlayerLevel { get; }
        IPlayerStatsPresenter PlayerStats { get; }
    }

    public interface IPlayerLevelPresenter
    {
        string PlayerLevelText { get; }
        string ExperienceText { get; }
        int CurrentExperience { get; }
        int RequiredExperience { get; }
        bool CanLevelUp { get; }
        void LevelUp();
    }

    //TODO: IPlayerExperiencePresenter
    public interface IPlayerExperiencePresenter
    {
        
    }

    public interface IUserInfoPresenter
    {
        string Name { get; }
        string Description { get; }
        Sprite Icon { get; }
    }

    public interface IPlayerStatsPresenter
    {
        string[] GetStats();
    }
}