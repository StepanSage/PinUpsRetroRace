using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageScroller : MonoBehaviour
{
    private RawImage _image;

    [SerializeField] private float _speedScroll;

    [SerializeField, Range(-1, 1)] private float _xDirection = 1;
    [SerializeField, Range(-1, 1)] private float _yDirection = 1;

    private void Start() => _image = GetComponent<RawImage>();

    private void Update()
        => _image.uvRect = new Rect(_image.uvRect.position + new Vector2(-_xDirection * _speedScroll, _yDirection * _speedScroll)  * Time.deltaTime, _image.uvRect.size);
    
        
    



}
