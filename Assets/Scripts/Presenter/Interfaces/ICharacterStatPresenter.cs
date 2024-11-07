using System;

namespace OtusUnityHomework.Presenter
{
    public interface ICharacterStatPresenter
    {
        string Name { get; }
        int Value { get; }
        event Action OnValueChanged;
    }
}