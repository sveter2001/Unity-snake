using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class body1Follow : MonoBehaviour
{
    
    private GameObject Snake;
    private GameObject body1;
    private SpriteRenderer sr;
    public Sprite straigth;
    public Sprite curve;
    //public Follow RF;
    // Start is called before the first frame update
    void Start()
    {
        Snake = GameObject.Find("Snake");
        body1 = GameObject.Find("body1");
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (body1.transform.eulerAngles[2] != Snake.transform.eulerAngles[2])
        {
            sr.sprite = curve;
            //RF.angle = Snake.transform.eulerAngles[2];
        }
        else
        {
            sr.sprite = straigth;
        }
    }
}
