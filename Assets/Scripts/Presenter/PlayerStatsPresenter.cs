using OtusUnityHomework.Model;

namespace OtusUnityHomework.Presenter
{
    public sealed class PlayerStatsPresenter : IPlayerStatsPresenter
    {
        private CharacterInfo _characterInfo;

        public PlayerStatsPresenter(CharacterInfo characterInfo)
        {
            _characterInfo = characterInfo;
        }
        
        public string[] GetStats()
        {
            var characterStats = _characterInfo.GetStats();
            var statTexts = new string[characterStats.Length];
            for (int i = 0; i < characterStats.Length; i++)
            {
                statTexts[i] = string.Concat(characterStats[i].Name, ": ", characterStats[i].Value.ToString());
            }
            
            return statTexts;
        }
    }
}