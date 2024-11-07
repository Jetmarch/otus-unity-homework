using System;
using System.Collections.Generic;
using OtusUnityHomework.Helpers;
using OtusUnityHomework.Model;

namespace OtusUnityHomework.Presenter
{
    public sealed class PlayerStatsPresenter : IPlayerStatsPresenter
    {
        public event Action OnStatsUpdated;
        
        private readonly CharacterInfo _characterInfo;
        private readonly CharacterStatPresenterFactory _characterStatPresenterFactory;
        public PlayerStatsPresenter(CharacterInfo characterInfo, CharacterStatPresenterFactory characterStatPresenterFactory)
        {
            _characterInfo = characterInfo;
            _characterStatPresenterFactory = characterStatPresenterFactory;
            _characterInfo.OnStatAdded += CharacterInfoOnStatAdded;
            _characterInfo.OnStatRemoved += CharacterInfoOnStatRemoved;
        }
        public List<ICharacterStatPresenter> GetStats()
        {
            var characterStats = _characterInfo.GetStats();
            var characterStatPresenters = new List<ICharacterStatPresenter>();
            for (int i = 0; i < characterStats.Length; i++)
            {
                if (characterStats[i] == null)
                {
                    continue;
                }
                
                var characterStatPresenter = _characterStatPresenterFactory.Create(characterStats[i]);
                characterStatPresenters.Add(characterStatPresenter);
            }
            
            return characterStatPresenters;
        }

        private void CharacterInfoOnStatAdded(CharacterStat obj)
        {
            OnStatsUpdated?.Invoke();
        }
        private void CharacterInfoOnStatRemoved(CharacterStat obj)
        {
            OnStatsUpdated?.Invoke();
        }
    }
}