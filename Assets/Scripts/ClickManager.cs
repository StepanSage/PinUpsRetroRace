using Scripts.Logica;

using UnityEngine;

public class ClickManager : MonoBehaviour
{
    [SerializeField] private Move moveCar;

    private void OnMouseDrag()
    {
        moveCar.MoveCar();   
    }


   
    


}
