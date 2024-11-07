using System;
using OtusUnityHomework.Model;
using OtusUnityHomework.Presenter;

namespace Presenter
{
    public sealed class CharacterStatPresenter : ICharacterStatPresenter
    {
        public string Name => _characterStat.Name;
        public int Value => _characterStat.Value;
        public event Action OnValueChanged;

        private readonly CharacterStat _characterStat;
        
        public CharacterStatPresenter(CharacterStat characterStat)
        {
            _characterStat = characterStat;
            _characterStat.OnValueChanged += CharacterStatOnValueChanged;
        }

        private void CharacterStatOnValueChanged(int obj)
        {
            OnValueChanged?.Invoke();
        }
    }
}