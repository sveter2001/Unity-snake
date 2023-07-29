using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using string;

    


public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 direction;
    private string a;

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
        a=Input.GetKey();
        switch (a)
        {
            case "w":
                direction.y = 1;
                break;
            case "a":
                direction.x = -1;
                break;
            case "s":
                direction.y = -1;
                break;
            case "d":
                direction.x = 1;
                break;
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition((rb.position + direction)* Time.fixedDeltaTime);
    }
}
