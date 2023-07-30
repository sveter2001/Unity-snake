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

    private void OnTriggerEnter2D(Collider2D col) {
        GameObject actual_food = GameObject.Find("Food");
        GameObject floor = GameObject.Find("Floor");
        actual_food.transform.position = new Vector2((float)(Random.value -0.5) * 10, (float)(Random.value -0.5) * 10);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w"))
        {
            direction.y = 1;
            direction.x = 0;
        }
        else if(Input.GetKey("a"))
        {
            direction.x = -1;
            direction.y = 0;
        }
        else if(Input.GetKey("s"))
        {
            direction.y = -1;
            direction.x = 0;
        }
        else if(Input.GetKey("d"))
        {
            direction.x = 1;
            direction.y = 0;
        }
    }

    void FixedUpdate()
    {
        Time.fixedDeltaTime = 0.5f;
        rb.MovePosition(rb.position + direction);
    }
}
