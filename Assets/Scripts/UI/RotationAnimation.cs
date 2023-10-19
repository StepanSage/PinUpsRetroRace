using UnityEngine;
using DG.Tweening;

namespace Scripts.UI
{
    public class RotationAnimation : MonoBehaviour
    {
        [SerializeField] private Vector3 _vectorRotation;
        [SerializeField] private float _speedAnimation;
        [SerializeField] bool _isGlobalRotation = true;
        private void Start() => Rotation();
    
        private void Rotation()
        {
            if(_isGlobalRotation)
            {
                transform.DORotate(_vectorRotation, _speedAnimation, RotateMode.FastBeyond360)
                    .SetEase(Ease.Linear)
                    .SetLoops(-1);
            }
            else
            {
                transform.DOLocalRotate(_vectorRotation, _speedAnimation, RotateMode.FastBeyond360)
                    .SetEase(Ease.Linear)
                    .SetLoops(-1);
            }
        }
    }
}

