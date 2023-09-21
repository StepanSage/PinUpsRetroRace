using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonGameMenu : MonoBehaviour
{
    public GameObject _MainScreen;
    public GameObject _SettingScreeb;
    [SerializeField] private GameObject _Gamemenu;
    [SerializeField] private AudioPlay audioPlay;
    [SerializeField] private GameObject[] _partica;

    private void OnMouseUpAsButton()
    {
        audioPlay.play();
        _MainScreen.SetActive(false);
        _MainScreen.SetActive(false);
        _Gamemenu.SetActive(true);
        Time.timeScale= 0f;

        for (int i = 0; i < _partica.Length; i++)
        {
            _partica[i].gameObject.SetActive(false);
        }
    }
}
