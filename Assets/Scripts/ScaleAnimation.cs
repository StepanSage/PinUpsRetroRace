using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UIElements;

public class ScaleAnimation : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Start()
    {
        Animation();
    }

    public void Animation()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(transform.DOScale(new Vector3(0.9f, 0.9f, 0), _speed).SetEase(Ease.Linear));
        sequence.Append(transform.DOScale(new Vector3(1f, 1f, 0), _speed).SetEase(Ease.Linear));
        sequence.SetLoops(-1);
    }
}
