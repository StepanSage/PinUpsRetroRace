using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonReturnMainMenu : MonoBehaviour
{
    private const int IDLodingeScense = 0;

    [Header("DelayForSound"), Space]
    private float _delayForSound = 0.3f;

    [SerializeField] private AudioPlay _audioPlay;

    private void Awake()
    {
        if (_audioPlay == null)
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
        SceneManager.LoadScene(IDLodingeScense);
    }


}
