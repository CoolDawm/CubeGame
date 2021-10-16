using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SRotate : MonoBehaviour
{
    [SerializeField]
    private float speed = 100.0f;
    private Vector2 currentDirection= new Vector3( 0 , 0 , 1.0f);
    private Transform transformObject;
    void Start()
    {
        transformObject = this.transform;
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 objectPos = transformObject.position;
            Vector2 direction = mousePos - objectPos;
            direction.Normalize();
            currentDirection = Vector2.Lerp(currentDirection, direction, Time.deltaTime * speed);
            transformObject.up = currentDirection;
        } 
    }
}
