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
    public Sprite straigth;
    public Sprite curveR;
    public Sprite curveL;
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
        //if (RF.angle == RFB.angle || Mathf.Abs(RF.angle - 180) == RFB.angle)
        rb.MovePosition(RF.oldPosition);

        if( Math.Abs(angle) > Math.Abs(transform.eulerAngles[2]))
        {
            sr.sprite = curveR;
            if (Math.Abs(transform.eulerAngles[2]) == 0 && Math.Abs(angle) == 270)
            {
                sr.flipX = true;
            }
        }
        else if(Math.Abs(angle) < Math.Abs(transform.eulerAngles[2]))
        {
            sr.sprite = curveL;
            if (oldangle == 270 && Math.Abs(angle) == 0)
            {
                sr.flipX = true;
            }

            // switch (angle)
            // {
            //     case 0:
            //         transform.position += new Vector3((float)-0.1,(float)-0.1,(float)0);
            //         break;
            //     case 90:
            //         transform.position += new Vector3((float)0.1,(float)-0.1,(float)0);
            //         break;
            //     case 180:
            //         transform.position += new Vector3((float)0.1,(float)0.1,(float)0);
            //         break;
            //     case 270:
            //         transform.position += new Vector3((float)-0.1,(float)0.1,(float)0);
            //         break;
            //     
            // }
        }
        else if(Math.Abs(angle) == Math.Abs(transform.eulerAngles[2]))
        {
            sr.sprite = straigth;
            sr.flipX = false;
        }
        
    }

    void FixedUpdate()
    {
        
        // transform.position -= delta;
        // delta = new Vector3((float)0,(float)0,(float)0);
        // if (Math.Abs(angle) < Math.Abs(transform.eulerAngles[2]))
        // {
        //     switch (angle)
        //     {
        //         case 0:
        //             delta = new Vector3((float)-0.1,(float)-0.1,(float)0);
        //             break;
        //         case 90:
        //             delta = new Vector3((float)0.1,(float)-0.1,(float)0);
        //             break;
        //         case 180:
        //             delta = new Vector3((float)0.1,(float)0.1,(float)0);
        //             break;
        //         case 270:
        //             delta = new Vector3((float)-0.1,(float)0.1,(float)0);
        //             break;
        //     }
        // }
        // transform.position += delta;
        
        angle = RF.transform.eulerAngles[2];
        oldangle = transform.eulerAngles[2];
        transform.eulerAngles = new Vector3(0.0f, 0.0f, RF.oldangle);
        
        //transform.eulerAngles = new Vector3(0.0f, 0.0f, angle);
        //Time.fixedDeltaTime = 0.5f;

    }
}
