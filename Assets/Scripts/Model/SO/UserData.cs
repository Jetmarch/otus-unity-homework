using UnityEngine;

namespace OtusUnityHomework.Model.SO
{
    [CreateAssetMenu(fileName = "UserData", menuName = "ScriptableObjects/UserData", order = 1)]
    public class UserData : ScriptableObject
    {
        [SerializeField] private UserInfo _userInfo;
        [SerializeField] private CharacterInfo _characterInfo;
        [SerializeField] private PlayerLevel _playerLevel;
    }
}