using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalTrigger : MonoBehaviour
{
    public int Score;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Goal")
        {
            transform.position = GameObject.Find("Ballposition").transform.position;
            this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            Score += 1;
        }
    }
    public void Update()
    {
        GameObject.Find("Score").GetComponent<TextMesh>().text = Score + "";
    }
}
