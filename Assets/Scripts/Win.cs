using Scripts.Logica;
using UnityEngine;


public class Win : MonoBehaviour
{  
    [SerializeField] private AudioClip audioClip;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private Move _move;

    [SerializeField] private GameObject _windowsWin;
    [SerializeField] private GameObject _screenMain;
    [SerializeField] private GameObject _screenSetting;
    [SerializeField] private GameObject[] _particl;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            if (collision.GetComponent<PlayerController>() != null)
            {
                audioSource.PlayOneShot(audioClip);
                _move.enabled = false;
                _windowsWin.SetActive(true);
                _screenMain.SetActive(false);
                _screenSetting.SetActive(false);

                for (int i = 0; i < _particl.Length; i++)
                {
                    _particl[i].SetActive(false);
                }
                
               
            }
        }
    }

   


}
