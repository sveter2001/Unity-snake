using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Food : MonoBehaviour
{
    private GameObject actual_food;
    private GameObject floor;
    // Start is called before the first frame update
    void Start()
    {
        floor = GameObject.Find("Grid");
        actual_food = GameObject.Find("Food");
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
