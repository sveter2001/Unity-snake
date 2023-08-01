using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 direction;
    public string save="";
    public Vector2 oldPosition;

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
            if (this.transform.eulerAngles.z != 0.0f){
                direction.y = 1;
                direction.x = 0;
                this.transform.eulerAngles = new Vector3(0.0f, 0.0f, 180.0f);
            }
            
        }
        else if(Input.GetKey("a"))
        {
            if (this.transform.eulerAngles.z != 90.0f){
                direction.x = -1;
                direction.y = 0;
                this.transform.eulerAngles = new Vector3(0.0f, 0.0f, 270f);
            }
        }
        else if(Input.GetKey("s"))
        {
            if (this.transform.eulerAngles.z != 180.0f){
                direction.y = -1;
                direction.x = 0;
                this.transform.eulerAngles = new Vector3(0.0f, 0.0f, 0.0f);
            }
        }
        else if(Input.GetKey("d"))
        {
            if (this.transform.eulerAngles.z != 270.0f){
                direction.x = 1;
                direction.y = 0;
                this.transform.eulerAngles = new Vector3(0.0f, 0.0f, 90.0f);
            }
        }
    }

    void FixedUpdate()
    {
        Time.fixedDeltaTime = 0.5f;
        oldPosition = rb.position;
        rb.MovePosition(rb.position + direction);
    }
}
