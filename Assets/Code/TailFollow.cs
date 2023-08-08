using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Food fd;
    private Rigidbody2D rb;
    public Follow RF;
    public GameObject Tailcrutch;

    void Start()
    {   
        Tailcrutch = GameObject.Find("Tailcrutch");
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;        
    }

    // Update is called once per frame
    void Update()
    {
        rb.MovePosition(RF.rb.position);
        //Tailcrutch.transform.position = new Vector2((float)0,(float)0);
        Tailcrutch.transform.position = transform.position;
        transform.eulerAngles = new Vector3(0.0f, 0.0f, RF.oldangle);

    }

    void FixedUpdate()
    {
        
        RF = fd.myBody[fd.length-1];
             
    }
}
