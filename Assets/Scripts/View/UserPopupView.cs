using OtusUnityHomework.Presenter;
using UnityEngine;

namespace OtusUnityHomework.View
{
    public sealed class UserPopupView : MonoBehaviour
    {
        [SerializeField] private UserInfoView _userInfoView;
        [SerializeField] private PlayerLevelView _playerLevelView;
        [SerializeField] private PlayerStatListView _playerStatListView;
        [SerializeField] private GameObject _userPopupContainer;
        
        
        private IUserPresenter _presenter; 
        
        public void Show(IUserPresenter presenter)
        {
            _presenter = presenter;
            _userPopupContainer.SetActive(true);
            _userInfoView.Show(presenter.UserInfo);
            _playerLevelView.Show(presenter.PlayerLevel);
            _playerStatListView.Show(presenter.PlayerStats);
        }

        public void Hide()
        {
            _userInfoView.Hide();
            _playerLevelView.Hide();
            _playerStatListView.Hide();
            _userPopupContainer.SetActive(false);
        }
    }
}