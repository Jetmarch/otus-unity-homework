namespace OtusUnityHomework.Presenter
{
    public sealed class UserPresenter : IUserPresenter
    {
        public IUserInfoPresenter UserInfo { get; }
        public IPlayerLevelPresenter PlayerLevel { get; }
        public IPlayerStatsPresenter PlayerStats { get; }
        
        public UserPresenter(IUserInfoPresenter userInfo, IPlayerLevelPresenter playerLevel, IPlayerStatsPresenter playerStats)
        {
            UserInfo = userInfo;
            PlayerLevel = playerLevel;
            PlayerStats = playerStats;
        }
    }
}