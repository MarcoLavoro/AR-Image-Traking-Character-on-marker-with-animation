using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManager : MonoBehaviour
{
    public Animator animator;
    public string[] ListAnimations = { "Pickup", "Wave" };
    int idxNextAnimation = 0;
    // Start is called before the first frame update
    public void ActivateNextAnimation()
    {

        animator.SetTrigger(ListAnimations[idxNextAnimation]);
        idxNextAnimation++;
        if (idxNextAnimation >= ListAnimations.Length) idxNextAnimation = 0;
    }
    private void Start()
    {
        animator.SetBool("Grounded", true);
    }
}
