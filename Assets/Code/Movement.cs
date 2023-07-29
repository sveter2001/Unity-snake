using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 direction;
    public string a="";

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direction.x=0;
        direction.y=0;
        if(Input.GetKey("w"))
        {
            direction.y = 1;
        }
        if(Input.GetKey("a"))
        {
             direction.x = -1;
        }
        if(Input.GetKey("s"))
        {
            direction.y = -1;
        }
        if(Input.GetKey("d"))
        {
            direction.x = 1;
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + direction);
    }
}
