using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonRestart : MonoBehaviour
{
    [SerializeField] private int _currentLevel;

    [Header("DelayForSound"), Space]
    private float _delayForSound = 0.3f;

    [SerializeField] private AudioPlay _audioPlay;

    private void Awake()
    {
        if(_audioPlay == null)
            _audioPlay = FindObjectOfType<AudioPlay>();
    }
    private void OnMouseUpAsButton()
    {
       _audioPlay.play();
        StartCoroutine("Delay");
    }

    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(_delayForSound);
        SceneManager.LoadScene(_currentLevel);
    }
}
