using OtusUnityHomework.Presenter;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace OtusUnityHomework.View
{
    public sealed class PlayerLevelView : MonoBehaviour
    {
        [SerializeField] private TMP_Text _currentLevelText;
        [SerializeField] private Slider _experienceSlider;
        [SerializeField] private TMP_Text _experienceSliderText;
        [SerializeField] private Button _levelUpButton;
        
        private IPlayerLevelPresenter _presenter;

        public void Show(IPlayerLevelPresenter presenter)
        {
            _presenter = presenter;
            gameObject.SetActive(true);
            
            _levelUpButton.onClick.AddListener(RequestLevelUp);
        }

        private void RequestLevelUp()
        {
            if (_presenter.CanLevelUp)
            {
                _presenter.LevelUp();
            }
        }

        public void Hide()
        {
            _levelUpButton.onClick.RemoveListener(RequestLevelUp);
            gameObject.SetActive(false);
        }
    }

    //TODO: ExperienceSliderView
    public sealed class ExperienceSliderView : MonoBehaviour
    {
        [SerializeField] private Slider _slider;
        [SerializeField] private TMP_Text _experienceText;

        public void Show(string experience)
        {
            
        }

        public void Hide()
        {
            
        }
    }
}