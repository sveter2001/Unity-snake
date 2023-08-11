using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class body1Follow : MonoBehaviour
{
    
    private GameObject Snake;
    private GameObject body1;
    private SpriteRenderer sr;
    public Sprite straigth;
    public Sprite curveR;
    public Sprite curveL;
    public float oldangle;
    //public Follow RF;
    // Start is called before the first frame update
    void Start()
    {
        Snake = GameObject.Find("Snake");
        body1 = GameObject.Find("body1");
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Math.Abs(body1.transform.eulerAngles[2]) < Math.Abs(Snake.transform.eulerAngles[2]))
        {
            sr.sprite = curveR;
            if (Math.Abs(body1.transform.eulerAngles[2]) == 0 && Math.Abs(Snake.transform.eulerAngles[2]) == 270)
            {
                sr.flipX = true;
            }
        }
        else if(Math.Abs(body1.transform.eulerAngles[2]) > Math.Abs(Snake.transform.eulerAngles[2]))
        {
            sr.sprite = curveL;
            if (oldangle == 270 && Math.Abs(Snake.transform.eulerAngles[2]) == 0)
            {
                sr.flipX = true;
            }
        }
        else if(Math.Abs(body1.transform.eulerAngles[2]) == Math.Abs(Snake.transform.eulerAngles[2]))
        {
            sr.sprite = straigth;
            sr.flipX = false;
        }
    }
    void FixedUpdate()
    {
        oldangle = transform.eulerAngles[2];
        
    }
}
