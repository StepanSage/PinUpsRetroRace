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
    

    private void Update()
    {
        if(CountCar == lose)
        {

            SceneManager.LoadScene(_currentSence);
           
        }
    }

    public void Count()
    {
        lose++;
        audioSource.PlayOneShot(audioClip);
    }
    
}
