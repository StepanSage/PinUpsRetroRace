using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullid : EnemyCutter
{
    public override void Move()
    {
        transform.DOMove(_endPosition.position, _speed).SetEase(Ease.Linear);
    }
}
