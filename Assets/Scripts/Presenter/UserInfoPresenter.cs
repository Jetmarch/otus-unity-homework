using System;
using OtusUnityHomework.Model;
using UnityEngine;

namespace OtusUnityHomework.Presenter
{
    public sealed class UserInfoPresenter : IUserInfoPresenter
    {
        public string Name => _userInfo.Name;
        public string Description => _userInfo.Description;
        public Sprite Icon => _userInfo.Icon;
        public event Action OnUserInfoChanged;

        private readonly UserInfo _userInfo;
        
        public UserInfoPresenter(UserInfo userInfo)
        {
            _userInfo = userInfo;   
            _userInfo.OnNameChanged += UserInfoOnOnNameChanged;
            _userInfo.OnDescriptionChanged += UserInfoOnOnDescriptionChanged;
            _userInfo.OnIconChanged += UserInfoOnOnIconChanged;
        }

        private void UserInfoOnOnNameChanged(string obj)
        {
            OnUserInfoChanged?.Invoke();
        }

        private void UserInfoOnOnDescriptionChanged(string obj)
        {
            OnUserInfoChanged?.Invoke();
        }

        private void UserInfoOnOnIconChanged(Sprite obj)
        {
            OnUserInfoChanged?.Invoke();
        }
    }
}