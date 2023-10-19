using UnityEngine;
using DG.Tweening;
using System.Collections;
using UnityEngine.UIElements;
using Unity.VisualScripting;

public class EnemyCutter : MonoBehaviour
{
    private bool IsAction;
    private GameObject _palaer;

    [SerializeField] protected Transform _endPosition;
    [SerializeField] protected float _speed;
    [SerializeField] private LoseController loseController;
    [SerializeField] private Vector3 _Rotetion;
    [SerializeField] private bool isRotetion= true;
    [SerializeField] private float currentTime = 1f;
    [SerializeField] private float startTime;
   
    
    void Start()
    {
        currentTime = 0.2f;
        startTime = currentTime;
        
        Move();
        Rotetion();
        
    }
    private void Update()
    {
        Delay();
    }

    public virtual void Move()
    {
        transform.DOMove(_endPosition.position, _speed).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);


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
                collision.transform.GetChild(1).gameObject.SetActive(true);
                _palaer =  collision.gameObject;
                IsAction = true;
               
            }
        }
    }

    public void Delay()
    {
        if (IsAction)
        {
            if (currentTime <= 0)
            {
                currentTime = startTime;
                _palaer.SetActive(false);
            }
            else
            {
                currentTime -= Time.deltaTime;
            }
        }
    }

   

   

   
}
