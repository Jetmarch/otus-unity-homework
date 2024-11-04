using TMPro;
using UnityEngine;

namespace OtusUnityHomework.View
{
    public sealed class PlayerStatView : MonoBehaviour
    {
        [SerializeField] private TMP_Text _statText;

        public void Show(string statText)
        {
            _statText.text = statText;
        }

        public void Hide()
        {
            _statText.text = string.Empty;
        }
    }
}