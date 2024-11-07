using System;
using System.Collections.Generic;
using OtusUnityHomework.Model;

namespace OtusUnityHomework.Presenter
{
    public sealed class PlayerStatsPresenter : IPlayerStatsPresenter
    {
        public event Action OnStatsUpdated;
        
        private readonly CharacterInfo _characterInfo;

        public PlayerStatsPresenter(CharacterInfo characterInfo)
        {
            _characterInfo = characterInfo;
            _characterInfo.OnStatAdded += CharacterInfoOnOnStatAdded;
            _characterInfo.OnStatRemoved += CharacterInfoOnOnStatRemoved;
        }
        public List<string> GetStats()
        {
            var characterStats = _characterInfo.GetStats();
            var statTexts = new List<string>();
            for (int i = 0; i < characterStats.Length; i++)
            {
                if (characterStats[i] == null)
                {
                    continue;
                }
                
                var newStatString = string.Concat(characterStats[i].Name, ": ", characterStats[i].Value.ToString());
                statTexts.Add(newStatString);
            }
            
            return statTexts;
        }

        private void CharacterInfoOnOnStatAdded(CharacterStat obj)
        {
            OnStatsUpdated?.Invoke();
        }
        private void CharacterInfoOnOnStatRemoved(CharacterStat obj)
        {
            OnStatsUpdated?.Invoke();
        }
    }
}