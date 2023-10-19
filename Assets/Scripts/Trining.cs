using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Trining : MonoBehaviour
{
    public string[] _monolog = new string[5];

    private int count;

    [SerializeField] private GameObject _trining;
    [SerializeField] private TMP_Text _text;
    [SerializeField] private GameObject _ScreenMain;
    [SerializeField] private GameObject[] _particl;


    private void Awake()
    {
        Time.timeScale = 0f;
        _monolog[0] = "��� ����������� ������� ����� ������� �����.";
        _monolog[1] = "���� � ��� �� ��������� �� ����� �����, �� ���������!!!";
        _monolog[2] = "�� ���� ���� �����������, �������� ������� ��������.";
        _monolog[3] = "��� ������ �� ��������� �� �������, �� �������";
        _monolog[4] = "�����!!!!";
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
            _text.text = _monolog[4];
        }
        else if(count == 5)
        {
            _ScreenMain.gameObject.SetActive(true);
            for (int i = 0; i < _particl.Length; i++)
            {
                _particl[i].SetActive(true);
            }
            Time.timeScale = 1f;
            Destroy(_trining);
        }
                
    }


    private void OnMouseDown()
    {
        count++;
    }


}
