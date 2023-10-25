using UnityEngine;
using DG.Tweening;


public class ScaleAnimation : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Start()
    {
        Animation();
    }

    public void Animation()
    {
        //Sequence sequence = DOTween.Sequence();
        //sequence.Append(transform.DOScale(new Vector3(0.9f, 0.9f, 0), _speed).SetEase(Ease.Linear));
        //sequence.Append(transform.DOScale(new Vector3(1f, 1f, 0), _speed).SetEase(Ease.Linear));
        //sequence.SetLoops(-1);
        //sequence.timeScale = 1f;

        Tween myTween = transform.DOScale(new Vector3(0.9f, 0.9f, 0), _speed)
            .SetEase(Ease.Linear)
            .SetLoops(-1, LoopType.Yoyo);
        myTween.timeScale = 1f;


        


    }
}
