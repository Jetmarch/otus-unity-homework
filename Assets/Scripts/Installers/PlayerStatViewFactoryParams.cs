using System;
using UnityEngine;

namespace OtusUnityHomework.Installers
{
    [Serializable]
    public struct PlayerStatViewFactoryParams
    {
        [SerializeField] public GameObject PlayerStatPrefab;
        [SerializeField] public GameObject PlayerStatsContainer;
    }
}