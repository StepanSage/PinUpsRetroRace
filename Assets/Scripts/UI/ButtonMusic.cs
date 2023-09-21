using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonMusic : MonoBehaviour
{
    public Sprite[] StateVolume = new Sprite[1];
    public Image _image;
    public bool IsState = true;
    [SerializeField] private AudioPlay audio;
    [SerializeField] private AudioSource audioSource;
    private int state;

    private void Awake()
    {
        int temp = PlayerPrefs.GetInt("stateMusic");
        if (temp  ==  0)
        {
            IsState = true;
            SwitchersMusic();
        }
        else if(temp == 1)
        {
            IsState= false;
            SwitchersMusic();
        }
    }

    public void OnMouseUpAsButton()
    {
        IsState = !IsState;
        SwitchersMusic();
    }


    public void SwitchersMusic()
    {
        audio.play();
        
        if (IsState)
        {
            _image.sprite = StateVolume[0];
            audioSource.volume = 0.4f;
            state = 0;
        }
        else
        {
            _image.sprite = StateVolume[1];
            audioSource.volume = 0;
            state = 1;
        }
        Save();
    }
    public void Save()
    {
        PlayerPrefs.SetInt("stateMusic", state); 
    }
}
