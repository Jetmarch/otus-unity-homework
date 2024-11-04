using System.Collections.Generic;
using OtusUnityHomework.Presenter;
using UnityEngine;

namespace OtusUnityHomework.View
{
    public sealed class PlayerStatListView : MonoBehaviour
    {
        private IPlayerStatsPresenter _presenter;
        
        private List<PlayerStatView> _playerStatViews;
        
        private PlayerStatViewFactory _playerStatViewFactory;

        public void Show(IPlayerStatsPresenter presenter)
        {
            _presenter = presenter;

            ShowStats();
        }

        private void ShowStats()
        {
            foreach (var statText in _presenter.GetStats())
            {
                var newStatView = _playerStatViewFactory.Create();
                _playerStatViews.Add(newStatView);
                newStatView.Show(statText);
            }
        }

        public void Hide()
        {
            foreach (var playerStatView in _playerStatViews)
            {
                playerStatView.Hide();
                Destroy(playerStatView.gameObject);
            }
        }
    }
}