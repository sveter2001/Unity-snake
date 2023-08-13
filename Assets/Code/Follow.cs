using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Follow RF;
    public Follow RFB;
    public Vector2 oldPosition;
    public Rigidbody2D rb;
    public float angle;
    private SpriteRenderer sr;
    public Sprite straigthV;
    public Sprite straigthH;
    public Sprite curve1;
    public Sprite curve2;
    public Sprite curve3;
    public Sprite curve4;
    public float oldangle;
    //private Vector3 delta = new Vector3((float)0,(float)0,(float)0); 
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
        sr = GetComponent<SpriteRenderer>();
    }
    
    // Update is called once per frame
    void Update()
    {
        
        oldPosition = rb.position;
        rb.MovePosition(RF.oldPosition);
        
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
        //transform.eulerAngles = new Vector3(0.0f, 0.0f, RF.oldangle);
        
        //transform.eulerAngles = new Vector3(0.0f, 0.0f, angle);
        //Time.fixedDeltaTime = 0.5f;

    }
}
