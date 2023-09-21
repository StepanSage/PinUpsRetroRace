using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueGame : MonoBehaviour
{
    public GameObject _MainScreen;
    public GameObject _SettingScreeb;
    [SerializeField] private GameObject _Gamemenu;
    [SerializeField] private AudioPlay audioPlay;
    [SerializeField] private GameObject[] _partocl;

    private void OnMouseUpAsButton()
    {
        audioPlay.play();
        _MainScreen.SetActive(true);
        _MainScreen.SetActive(true);
        _Gamemenu.SetActive(false);
        Time.timeScale = 1.0f;

        for (int i = 0; i < _partocl.Length; i++)
        {
            _partocl[i].SetActive(true);
        }
    }
}
