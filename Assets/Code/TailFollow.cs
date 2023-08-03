using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Food fd;
    private Rigidbody2D rb;
    public Follow RF;
    void Start()
    {   
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;        
    }

    // Update is called once per frame
    void Update()
    {
        rb.MovePosition(RF.rb.position);   
    }

    void FixedUpdate()
    {
        RF = fd.myBody[fd.length-1];
             
    }
}
