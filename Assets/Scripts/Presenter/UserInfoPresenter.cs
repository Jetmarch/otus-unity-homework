using OtusUnityHomework.Model;
using UnityEngine;

namespace OtusUnityHomework.Presenter
{
    public sealed class UserInfoPresenter : IUserInfoPresenter
    {
        public string Name => _userInfo.Name;
        public string Description => _userInfo.Description;
        public Sprite Icon => _userInfo.Icon;

        private readonly UserInfo _userInfo;
        
        public UserInfoPresenter(UserInfo userInfo)
        {
            _userInfo = userInfo;   
        }
    }
}