using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonMusic : MonoBehaviour
{
   
   
    private bool _isActive = true;
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

    public void OnMouseUpAsButton()
    {
        _isActive = !_isActive;
        exsportSoundVolume.ChangeVolume(_isActive);

    }


   
    
}
