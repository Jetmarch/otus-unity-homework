using OtusUnityHomework.Helpers;
using OtusUnityHomework.View;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace OtusUnityHomework.Installers
{
    public class UILifetimeScope : LifetimeScope
    {
        [SerializeField] private PlayerStatViewFactoryParams _playerStatViewFactoryParams;
        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<UserPresenterFactory>(Lifetime.Singleton);
            builder.Register<PlayerStatViewFactory>(Lifetime.Singleton)
                .WithParameter(_playerStatViewFactoryParams);
        }
    }
}