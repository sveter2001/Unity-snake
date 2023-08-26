using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FoodType : MonoBehaviour
{
    public int TTL;

    public Animator animator;
    void Update()
    {
        TTL -= 1;
        animator.SetInteger("TTL", TTL);
    }
}
