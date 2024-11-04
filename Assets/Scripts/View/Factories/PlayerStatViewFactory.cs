using System;
using OtusUnityHomework.Installers;
using UnityEngine;
using Object = UnityEngine.Object;

namespace OtusUnityHomework.View
{
    public sealed class PlayerStatViewFactory
    {
        private readonly GameObject _playerStatPrefab;
        private readonly GameObject _playerStatsContainer;
        public PlayerStatViewFactory(PlayerStatViewFactoryParams factoryParams)
        {
            _playerStatPrefab = factoryParams.PlayerStatPrefab;
            _playerStatsContainer = factoryParams.PlayerStatsContainer;
        }
        
        public PlayerStatView Create()
        {
            var newStatView = Object.Instantiate(_playerStatPrefab, _playerStatsContainer.transform).GetComponent<PlayerStatView>();
            if (newStatView == null)
            {
                throw new ApplicationException("PlayerStatView prefab does not contain PlayerStatView component");
            }
            
            return newStatView;
        }
    }
}