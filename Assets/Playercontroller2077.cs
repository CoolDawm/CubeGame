using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Playercontroller2077 : MonoBehaviour
{
    float Vert, Horiz;
    public float Speed=5;
    void Update()
    {
        Vert = Input.GetAxis("Vertical") * Time.deltaTime *  Speed;
        Horiz = Input.GetAxis("Horizontal") * Time.deltaTime * Speed;
        transform.Translate(new Vector3(Horiz, 0, Vert));
    }
}
