using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonExit : MonoBehaviour
{
    [SerializeField] private AudioPlay audioPlay;
    private void OnMouseUpAsButton()
    {
        audioPlay.play();
        Application.Quit();
    }
}
