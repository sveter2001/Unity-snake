using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class body1Follow : MonoBehaviour
{
    
    private GameObject Snake;
    private GameObject body1;
    private SpriteRenderer sr;
    public Sprite straigthV;
    public Sprite straigthH;
    public Sprite curve1;
    public Sprite curve2;
    public Sprite curve3;
    public Sprite curve4;
    public float oldangle;
    public float angle;
    public Follow RF;
    public Follow RFB;
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

        if (RF.transform.position.x > transform.position.x && RF.transform.position.y == transform.position.y)
        {
            if (RFB.transform.position.y > transform.position.y)
            {
                //sprite
                sr.sprite = curve3;
                //delta
            }
            else if (RFB.transform.position.y < transform.position.y)
            {
                //sprite
                sr.sprite = curve1;
                //delta
            }
            else if(RFB.transform.position.x == RF.transform.position.x)
            {
                sr.sprite = straigthH;
            }
            else
            {
                sr.sprite = straigthV;
            }
        }
        else if (RF.transform.position.x < transform.position.x && RF.transform.position.y == transform.position.y)
        {
            if (RFB.transform.position.y > transform.position.y)
            {
                //sprite
                sr.sprite = curve4;
                //delta
            }
            else if (RFB.transform.position.y < transform.position.y)
            {
                //sprite
                sr.sprite = curve2;
                //delta
            }
            else if(RFB.transform.position.x == RF.transform.position.x)
            {
                sr.sprite = straigthH;
            }
            else
            {
                sr.sprite = straigthV;
            }
        }
        else if (RF.transform.position.x == transform.position.x && RF.transform.position.y > transform.position.y)
        {
            if (RFB.transform.position.x > transform.position.x)
            {
                //sprite
                sr.sprite = curve3;
                //delta
            }
            else if (RFB.transform.position.x < transform.position.x)
            {
                //sprite
                sr.sprite = curve4;
                //delta
            }
            else if(RFB.transform.position.x == RF.transform.position.x)
            {
                sr.sprite = straigthH;
            }
            else
            {
                sr.sprite = straigthV;
            }
        }
        else if (RF.transform.position.x == transform.position.x && RF.transform.position.y < transform.position.y)
        {
            if (RFB.transform.position.x > transform.position.x)
            {
                //sprite
                sr.sprite = curve1;
                //delta
            }
            else if (RFB.transform.position.x < transform.position.x)
            {
                //sprite
                sr.sprite = curve2;
                //delta
            }
            else if(RFB.transform.position.x == RF.transform.position.x)
            {
                sr.sprite = straigthH;
            }
            else
            {
                sr.sprite = straigthV;
            }
        }
    }
    void FixedUpdate()
    {
        angle = RF.transform.eulerAngles[2];
        oldangle = transform.eulerAngles[2];
        
    }
}
