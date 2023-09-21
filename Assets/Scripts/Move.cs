using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float Speed;
    public GameObject Menu;

    public void Awake()
    {
        Menu.gameObject.SetActive(true);
    }
    public void Start()
    {
        Menu.gameObject.SetActive(false);
    }


    public void MoveCar()
    {
       
        transform.Translate(new Vector3(0, -1, 0) * Speed * Time.deltaTime);
    }
   
}
