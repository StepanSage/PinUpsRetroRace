using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Trining : MonoBehaviour
{
    public string[] _monolog = new string[4];
    [SerializeField] private GameObject _trining;
    [SerializeField] private TMP_Text _text;
    [SerializeField] private GameObject _ScreenMain;
    private int count;


    private void Awake()
    {
       
        _monolog[0] = "To move the car, hold down the key on the screen";
        _monolog[1] = "If we don't have any cars left, we will lose!!!";
        _monolog[2] = "There is an obstacle on the way that should be avoided.";
        _monolog[3] = "as soon as we get to the finish line we will win";
        Time.timeScale = 0f;
    }

    private void Update()
    {
        _ScreenMain.gameObject.SetActive(false);
        if (count == 0)
        {
            _text.text = _monolog[0]; 
        }
        else if(count ==1 )
        {
            _text.text = _monolog[1];
        }
        else if (count == 2)
        {
            _text.text = _monolog[2];
        }
        else if(count == 3)
        {
            _text.text = _monolog[3];
        }
        else if (count== 4)
        {
            _ScreenMain.gameObject.SetActive(true);
            Time.timeScale = 1f;
            Destroy(_trining);
        }
                
    }


    private void OnMouseDown()
    {
        count++;
    }


}
