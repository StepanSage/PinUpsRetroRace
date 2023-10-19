using UnityEngine;

public class AudioPlay : MonoBehaviour
{
    [SerializeField] private AudioClip _clip;

    [SerializeField] private AudioSource _audioSource;

    private float  maxtim;
    private float  CuttrntTime = 1f;

    public void Start()
    {
        maxtim = CuttrntTime;
    }
    public void play()
    {
        _audioSource.PlayOneShot(_clip);


    }
}
