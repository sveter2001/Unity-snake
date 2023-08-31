using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 direction;
    public Vector2 oldPosition;
    private float angle;
    [SerializeField] public Follow RF;
    [SerializeField] public StartScript StartScript;

    [SerializeField] public static float speed;  //the smaller, the faster

    private const float TOLERANCE = 0.1f;
    public const float SPEED_LOWER = 0.9f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = 0.5f;
        //direction.x = -1;
        StartScript.stop();
        angle = 270.0f;//transform.eulerAngles[2];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            if (Math.Abs(transform.eulerAngles.z - 0.0f) < TOLERANCE) return;
            StartScript.plaing();
            direction.y = 1;
            direction.x = 0;
            angle = 180.0f;
            //RF.angle = 180.0f;
        }
        else if (Input.GetKey("a"))
        {
            if (Math.Abs(transform.eulerAngles.z - 90.0f) < TOLERANCE) return;
            StartScript.plaing();
            direction.x = -1;
            direction.y = 0;
            angle = 270.0f;
            //RF.angle = 270.0f;
        }
        else if (Input.GetKey("s"))
        {
            if (Math.Abs(transform.eulerAngles.z - 180.0f) < TOLERANCE) return;
            StartScript.plaing();
            direction.y = -1;
            direction.x = 0;
            angle = 0.0f;
            //RF.angle = 0.0f;
        }
        else if (Input.GetKey("d"))
        {
            if (Math.Abs(transform.eulerAngles.z - 270.0f) < TOLERANCE) return;
            direction.x = 1;
            direction.y = 0;
            angle = 90.0f;
            //RF.angle = 90.0f;
        }
    }

    void FixedUpdate()
    {
        // if (Input.GetKey("w"))
        // {
        //     RF.angle = 180.0f;
        // }
        // else if (Input.GetKey("a"))
        // {
        //     RF.angle = 270.0f;
        // }
        // else if (Input.GetKey("s"))
        // {
        //     RF.angle = 0.0f;
        // }
        // else if (Input.GetKey("d"))
        // {
        //     RF.angle = 90.0f;
        // }
        Time.fixedDeltaTime = speed;
        oldPosition = rb.position;
        rb.MovePosition(rb.position + direction);
        transform.eulerAngles = new Vector3(0.0f, 0.0f, angle);
    }
}
