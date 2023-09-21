using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPlay : MonoBehaviour
{
    [SerializeField] AudioPlay audioPlay;
    [SerializeField] ButtonMusic buttonMusic;
    private void OnMouseUpAsButton()
    {
        audioPlay.play();
        buttonMusic.Save();
        SceneManager.LoadScene(1);

    }
}
