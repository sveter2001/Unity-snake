using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Follow RF;
    public Vector2 oldPosition;
    public Rigidbody2D rb;
    public bool special;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        oldPosition = rb.position;
        rb.MovePosition(RF.oldPosition);
    }

    void FixedUpdate()
    {
            
        //Time.fixedDeltaTime = 0.5f;
        
    }
}
