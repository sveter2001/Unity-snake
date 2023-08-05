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
    public Sprite curve;
    public float oldangle;
    
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
    }

    void FixedUpdate()
    {
        angle = transform.eulerAngles[2];
        oldangle = transform.eulerAngles[2];
        transform.eulerAngles = new Vector3(0.0f, 0.0f, RF.oldangle);
        if (RF.angle == RFB.angle || Mathf.Abs(RF.angle - 180) == RFB.angle)
        {
            sr.sprite = straigth;
        }
        else
        {
            sr.sprite = curve;
        }
        //transform.eulerAngles = new Vector3(0.0f, 0.0f, angle);
        //Time.fixedDeltaTime = 0.5f;

    }
}
