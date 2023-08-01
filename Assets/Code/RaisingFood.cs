using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Food : MonoBehaviour
{
    //[SerializeField] private Body[] myBody = new Body[999];
    [SerializeField] public Sprite sprite11;
    [SerializeField] public Sprite sprite22;
    public Follow[] myBody = new Follow[999];

    private GameObject actual_food;
    private GameObject floor;
    private GameObject Snake;
    public GameObject body1;
    private GameObject Tail;
    public Follow fb1;
    public int length=1;
    // Start is called before the first frame update
    void Start()
    {
        floor = GameObject.Find("Grid");
        actual_food = GameObject.Find("Apple");
        Snake = GameObject.Find("SnakeInner");
        Tail = GameObject.Find("Tail");
        body1 = GameObject.Find("body1");
        fb1 = body1.GetComponent<Follow>();
        myBody[0]=fb1;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D col) {
        actual_food.transform.position = new Vector2(
            (float)Mathf.Round((float)Random.Range(-26, 12)) + (float)0.5, 
            (float)Mathf.Round((float)Random.Range(-31, 7)) + (float)0.5);
        Debug.Log(actual_food.transform.position);

        // Body piece = obj.AddComponent<Body>();
        // piece.Body1(sprite11,sprite22,spriteRender12);
        // piece.gameObject.SetActive(true);
        // piece.spriteRender.sortingOrder = 40;
        //myBody[length] = piece;
        
             
        GameObject go1 = new GameObject();
        go1.name = "go"+length.ToString();
        SpriteRenderer render = go1.AddComponent<SpriteRenderer>();
        Rigidbody2D rb = go1.AddComponent<Rigidbody2D>();
        rb.MovePosition(Tail.GetComponent<Rigidbody2D>().position);
        rb.gravityScale = 0;
        //go1.transform.SetParent(Snake.transform);

        //SpriteRenderer render = go1.GetComponent<SpriteRenderer>();
        render.sprite = sprite11;

        Follow fl1 = go1.AddComponent<Follow>();
        fl1.RF = myBody[length-1];
        myBody[length]=fl1;

        




        //  go1.transform.position = new Vector2(
        //      (float)Mathf.Round((float)Tail.transform.position.x)+ (float)0.5, 
        //      (float)Mathf.Round((float)Tail.transform.position.y)+ (float)0.5);


        //     if (Tail.transform.eulerAngles.z == 0.0f){
        //         Tail.transform.position = new Vector2(
        //     (float)Mathf.Round((float)Tail.transform.position.x-1)+ (float)0.5, 
        //     (float)Mathf.Round((float)Tail.transform.position.y)+ (float)0.5);
        //     }
        //     if (Tail.transform.eulerAngles.z == 0.90f){
        //         Tail.transform.position = new Vector2(
        //             (float)Mathf.Round((float)Tail.transform.position.x)+ (float)0.5,
        //             (float)Mathf.Round((float)Tail.transform.position.y-1)+ (float)0.5);
        //     }
        //     if (Tail.transform.eulerAngles.z == 0.180f){
        //         Tail.transform.position = new Vector2(
        //     (float)Mathf.Round((float)Tail.transform.position.x+1)+ (float)0.5, 
        //     (float)Mathf.Round((float)Tail.transform.position.y)+ (float)0.5);
        //     }
        //     if (Tail.transform.eulerAngles.z == 0.270f){
        //         Tail.transform.position = new Vector2(
        //     (float)Mathf.Round((float)Tail.transform.position.x)+ (float)0.5, 
        //     (float)Mathf.Round((float)Tail.transform.position.y+1)+ (float)0.5);
        //     }
        length++;
        //myBody[length] = go1;
        
    }

    public static Rect Get_Rect(GameObject gameObject)
    {
        if (gameObject != null)
        {
            RectTransform rectTransform =  gameObject.GetComponent<RectTransform>();

            if (rectTransform != null)
            {
                return rectTransform.rect;
            }
        }
        else
        {
            Debug.Log("Game object is null.");
        }

        return new Rect();
    }

    public static float Get_Width(GameObject gameObject)
    {
        if (gameObject != null)
        {
            var rect = Get_Rect(gameObject);
            if (rect != null)
            {
                return rect.width;
            }
        }

        return 0;
    }

    public static float Get_Height(GameObject gameObject)
    {
        if (gameObject != null)
        {
            var rect = Get_Rect(gameObject);
            if (rect != null)
            {
                return rect.height;
            }
        }

        return 0;
    }
}
