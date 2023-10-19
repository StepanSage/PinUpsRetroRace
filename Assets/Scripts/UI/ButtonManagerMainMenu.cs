using UnityEngine;
using UnityEngine.SceneManagement;

namespace Scripts.UI 
{
    public class ButtonManagerMainMenu : MonoBehaviour
    {

        private bool _isActive = true;
        private const int  IDScence = 2;
        private ExsportSoundVolume exsportSoundVolume;
        
       
        private void Awake()
        {
            exsportSoundVolume = FindObjectOfType<ExsportSoundVolume>();
            string Active = PlayerPrefs.GetString("IsActive");
            bool IsEmpty = string.IsNullOrEmpty(Active);

            if (!IsEmpty)
            {
                _isActive = bool.Parse(Active);
            }
        }

        public void Play() => SceneManager.LoadScene(IDScence);


        public void SoundSwitch()
        {
            _isActive = !_isActive; 
            exsportSoundVolume.ChangeVolume(_isActive);           
        }

        public void Quit()
        {
            Application.Quit();
        }
    }
}


