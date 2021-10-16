using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float sensivity = 6.0f;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * sensivity, 0f);
        }
    }
}
