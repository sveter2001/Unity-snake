using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Food fd;
    private Rigidbody2D rb;
    public Follow RF;
    public GameObject Tailcrutch;
    private SpriteRenderer sr;
    public Sprite straigthV;
    public Sprite straigthH;

    void Start()
    {   
        Tailcrutch = GameObject.Find("Tailcrutch");
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.MovePosition(RF.rb.position);
        //Tailcrutch.transform.position = new Vector2((float)0,(float)0);
        Tailcrutch.transform.position = transform.position;
        transform.eulerAngles = new Vector3(0.0f, 0.0f, RF.oldangle);
        if (RF.transform.position.x > transform.position.x)
        {
            sr.sprite = straigthV;
            sr.flipY = false;
            sr.flipX = false;
        }
        else if (RF.transform.position.x < transform.position.x)
        {
            sr.sprite = straigthV;
            sr.flipY = false;
            sr.flipX = true;
        }
        else if (RF.transform.position.y > transform.position.y)
        {
            sr.sprite = straigthH;
            sr.flipY = false;
            sr.flipX = false;
        }
        else if (RF.transform.position.y < transform.position.y)
        {
            sr.sprite = straigthH;
            sr.flipX = false;
            sr.flipY = true;
        }

    }

    void FixedUpdate()
    {
        
        RF = fd.myBody[fd.length-1];
             
    }
}
