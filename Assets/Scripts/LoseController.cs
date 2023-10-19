using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseController : MonoBehaviour
{
    [SerializeField] private int lose;
    [SerializeField] private int CountCar;
    [SerializeField] private int _currentSence;
    [SerializeField] private AudioClip audioClip;
    [SerializeField] private AudioSource audioSource;

    [SerializeField] private GameObject _restatMenu;
    [SerializeField] private GameObject _mainScreen;
    [SerializeField] private GameObject _settingScreen;

    [SerializeField] private GameObject[] _particl;
    

    private void Update()
    {
        if(CountCar == lose)
        {
            _mainScreen.SetActive(false);
            _settingScreen.SetActive(false);
            _restatMenu.SetActive(true);
            for (int i = 0; i < _particl.Length; i++)
            {
                _particl[i].SetActive(false);
            }
        }
    }

    public void Count()
    {
        lose++;
        audioSource.PlayOneShot(audioClip);

    }
    
}
