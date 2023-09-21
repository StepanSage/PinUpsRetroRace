using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    [SerializeField] private int _nextLevel;
    [SerializeField] private AudioClip audioClip;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private Move move;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            if (collision.GetComponent<PlayerController>() != null)
            {
                audioSource.PlayOneShot(audioClip);
                move.Speed= 0;
                StartCoroutine("Delay");
            }
        }
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(2.2f);
        SceneManager.LoadScene(_nextLevel);

    }


}
