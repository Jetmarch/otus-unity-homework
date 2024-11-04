using OtusUnityHomework.Model.SO;
using OtusUnityHomework.Presenter;

namespace OtusUnityHomework.Helpers
{
    public sealed class UserPresenterFactory
    {
        public UserPresenter Create(UserData userData)
        {
            var userInfoPresenter = new UserInfoPresenter(userData.UserInfo);
            var playerLevelPresenter = new PlayerLevelPresenter(userData.PlayerLevel);
            var playerStatsPresenter = new PlayerStatsPresenter(userData.CharacterInfo);
            
            var userPresenter = new UserPresenter(userInfoPresenter, playerLevelPresenter, playerStatsPresenter);
            return userPresenter;
        }
    }
}