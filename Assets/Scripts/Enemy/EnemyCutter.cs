using UnityEngine;
using DG.Tweening;
using System.Collections;

public class EnemyCutter : MonoBehaviour
{
    [SerializeField] protected Vector2 _endPosition;
    [SerializeField] protected float _speed;
    [SerializeField] private LoseController loseController;
    [SerializeField] private Vector3 _Rotetion;
    [SerializeField] private bool isRotetion= true; 
   
    
    void Start()
    {
        Move();
        Rotetion();
        
    }

    public virtual void Move()
    {
        transform.DOMove(_endPosition, _speed).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }

    public void Rotetion()
    {
        if(isRotetion) 
        transform.DORotate(_Rotetion, _speed, RotateMode.FastBeyond360).SetEase(Ease.Linear).SetLoops(-1, LoopType.Restart);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            if (collision.GetComponent<PlayerController>() != null)
            {
                loseController.Count();
                collision.gameObject.SetActive(false);
            }
        }
    }

   

   
}
