using System.Collections.Generic;
using OtusUnityHomework.Presenter;
using UnityEngine;
using VContainer;

namespace OtusUnityHomework.View
{
    public sealed class PlayerStatListView : MonoBehaviour
    {
        private IPlayerStatsPresenter _presenter;
        
        private readonly List<CharacterStatView> _playerStatViews = new();
        
        private PlayerStatViewFactory _playerStatViewFactory;

        [Inject]
        private void Construct(PlayerStatViewFactory playerStatViewFactory)
        {
            _playerStatViewFactory = playerStatViewFactory;
        }

        public void Show(IPlayerStatsPresenter presenter)
        {
            _presenter = presenter;
            gameObject.SetActive(true);
            _presenter.OnStatsUpdated += ShowStats;
            ShowStats();
        }

        private void ShowStats()
        {
            foreach (var playerStatView in _playerStatViews)
            {
                Destroy(playerStatView.gameObject);
            }
            _playerStatViews.Clear();
            
            foreach (var characterStatPresenter in _presenter.GetStats())
            {
                var newStatView = _playerStatViewFactory.Create();
                newStatView.Show(characterStatPresenter);
                _playerStatViews.Add(newStatView);
            }
        }

        public void Hide()
        {
            foreach (var playerStatView in _playerStatViews)
            {
                playerStatView.Hide();
                Destroy(playerStatView.gameObject);
            }
            _playerStatViews.Clear();
            _presenter.OnStatsUpdated -= ShowStats;
            gameObject.SetActive(false);
        }
    }
}