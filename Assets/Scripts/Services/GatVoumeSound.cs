using UnityEngine;
using UnityEngine.UI;

class GatVoumeSound : MonoBehaviour
{
    private float _volume;
    private bool _isActive;

    [Header("Sound"), Space]
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private Sprite _onSoundSprite = null;
    [SerializeField] private Sprite _offSoundSprite = null;
    [SerializeField] private Image ImageSound;

    private void Start()
    {
        string Active = PlayerPrefs.GetString("IsActive");
        bool IsEmpty = string.IsNullOrEmpty(Active);

        if (!IsEmpty)
        {
            _isActive = bool.Parse(Active);
            Set(_isActive);
        }
    }

    public void Set(bool Volume)
    {
        if(Volume)
        {
            ImageSound.sprite = _onSoundSprite;
        }
        else
        {
            ImageSound.sprite = _offSoundSprite;
        }

        _audioSource.enabled = Volume;

    }

}