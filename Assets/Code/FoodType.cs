using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FoodType : MonoBehaviour
{
    public int TTL;
    void Update()
    {
        // Time.fixedDeltaTime = 1f;
        TTL -= 1;
    }
}