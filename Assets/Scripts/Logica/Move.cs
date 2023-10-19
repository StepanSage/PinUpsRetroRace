using UnityEngine;

namespace Scripts.Logica 
{
    public class Move : MonoBehaviour
    {
        [SerializeField] private float _speed;
           
        public void MoveCar()
        {
       
            transform.Translate(new Vector3(0, -1, 0) * _speed * Time.deltaTime);
        }
   
    }

}

