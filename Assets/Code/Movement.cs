using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 direction;
    public string save="";

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
            save = "w";
            direction.y = 1;
        }
        else if(Input.GetKey("a"))
        {
            save="a";
            direction.x = -1;
        }
        else if(Input.GetKey("s"))
        {
            save="s";
            direction.y = -1;
        }
        else if(Input.GetKey("d"))
        {
            save="d";
            direction.x = 1;
        }
        else if (save == "w"){
            direction.y = 1;
        }
        else if (save == "a"){
            direction.x = -1;
        }
        else if (save == "s"){
            direction.y = -1;
        }
        else if (save == "d"){
            direction.x = 1;
        }
    }

    void FixedUpdate()
    {
        Time.fixedDeltaTime = 0.5f;
        rb.MovePosition(rb.position + direction);
    }
}
