using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    public Animation ScaleAnimation;

    private void OnCollisionEnter(Collision col)
    {
        col.gameObject.GetComponent<AnimationTrigger>().PlayAnimation();
    }

    public void PlayAnimation()
    {
        ScaleAnimation.Play();
    }
}
