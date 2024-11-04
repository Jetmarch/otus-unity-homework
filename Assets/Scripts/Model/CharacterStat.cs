using System;
using Sirenix.OdinInspector;

namespace OtusUnityHomework.Model
{
    [Serializable]
    public sealed class CharacterStat
    {
        public event Action<int> OnValueChanged; 

        [ShowInInspector]
        public string Name { get; private set; }

        [ShowInInspector, ReadOnly]
        public int Value { get; private set; }

        [Button]
        public void ChangeValue(int value)
        {
            this.Value = value;
            this.OnValueChanged?.Invoke(value);
        }
    }
}