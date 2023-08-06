using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FoodSpawn : MonoBehaviour
{
    public List<GameObject> foods;
    public Sprite sprite_for_all;

    private int count;
    // Start is called before the first frame update

    void Spawn(int ttl)
    {
        count += 1;
        GameObject new_food = new GameObject();
        new_food.tag = "Food";
        new_food.name = "Food" + count.ToString();

        FoodType ft = new_food.AddComponent<FoodType>();
        ft.TTL = ttl;
        
        BoxCollider2D box = new_food.AddComponent<BoxCollider2D>();
        box.isTrigger = true;
        
        Rigidbody2D rb = new_food.AddComponent<Rigidbody2D>();
        rb.gravityScale = 0;

        SpriteRenderer sr = new_food.AddComponent<SpriteRenderer>();
        sr.sprite = sprite_for_all;
        
        new_food.transform.position = new Vector2(
            Mathf.Round(Random.Range(-26, 12)) + (float)0.5, 
            Mathf.Round(Random.Range(-31, 7)) + (float)0.5);

        foods.Add(new_food);
    }
    
    void Start()
    {
        count = 0;
        
        Spawn(6000);
        Debug.Log("spawn start");
    }

    void FixedUpdate()
    {
        // Time.fixedDeltaTime = 1f;
        // foreach (var food in foods)
        // {
        //     FoodType ft = food.GetComponent<FoodType>();
        //
        //     if (food.GetComponent<FoodType>().TTL <= 0)
        //     {
        //         foods.Remove(food);
        //         Destroy(food);
        //         Debug.Log("Destroyed");
        //     }
        //     
        // }

        int i = 0;
        while (true)
        {
            GameObject food = foods[i];
            
            if (food.GetComponent<FoodType>().TTL <= 0)
            {
                foods.RemoveAt(i);
                Destroy(food);
                Debug.Log("Destroyed");
                i = Mathf.Min(i - 1, 0);
            }

            i += 1;
        }
    }
    
    private void OnTriggerEnter2D(Collider2D col) {
        if (col.CompareTag("Food"))
        {
            foods.Remove(col.GameObject());
            Destroy(col.GameObject());
            Spawn(6000);
            Debug.Log("Spawned" + foods[-1].name);
        }
    }
}
