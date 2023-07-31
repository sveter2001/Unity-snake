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
        if(Input.GetKey("w"))
        {
            direction.y = 1;
            direction.x = 0;
            this.transform.Rotate(0.0f, 0.0f, 180.0f - this.transform.rotation.z, Space.Self);
        }
        else if(Input.GetKey("a"))
        {
            direction.x = -1;
            direction.y = 0;
            this.transform.Rotate(0.0f, 0.0f, 270.0f - this.transform.rotation.z, Space.Self);
        }
        else if(Input.GetKey("s"))
        {
            direction.y = -1;
            direction.x = 0;
            this.transform.Rotate(0.0f, 0.0f, 0.0f - this.transform.rotation.z, Space.Self);
        }
        else if(Input.GetKey("d"))
        {
            direction.x = 1;
            direction.y = 0;
            this.transform.Rotate(0.0f, 0.0f, 90.0f - this.transform.rotation.z, Space.Self);
        }
    }

    void FixedUpdate()
    {
        Time.fixedDeltaTime = 0.5f;
        rb.MovePosition(rb.position + direction);
    }
}
