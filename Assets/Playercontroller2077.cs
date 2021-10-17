using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Playercontroller2077 : MonoBehaviour
{
    public float sensivity = 6.0f;
    float Vert, Horiz;
    public float Speed=5;
    void Update()
    {
        Vert = Input.GetAxis("Vertical") * Time.deltaTime *  Speed;
        Horiz = Input.GetAxis("Horizontal") * Time.deltaTime * Speed;
        transform.Translate(new Vector3(Horiz, 0, Vert));
        if (Input.GetMouseButton(0))
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * sensivity, 0f);
        }
    }
    
    
        
    
}
