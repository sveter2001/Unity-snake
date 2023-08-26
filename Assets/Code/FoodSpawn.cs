using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Object = UnityEngine.Object;
using Random = UnityEngine.Random;

public class FoodSpawn : MonoBehaviour
{
    public List<GameObject> foods;

    private int count;
    
    public GameObject[] myPrefabs;

    void Spawn(int ttl)
    {
        count += 1;
        // GameObject new_food = new GameObject();
        GameObject new_food = Instantiate(myPrefabs[Random.Range(0, myPrefabs.Length - 1)], 
            new Vector3(0, 0, 0), Quaternion.identity);
        
        new_food.tag = "Food";
        new_food.name = "Food" + count.ToString();

        new_food.GetComponent<FoodType>().TTL = ttl;

        // FoodType ft = new_food.AddComponent<FoodType>();
        // ft.TTL = ttl;
        //
        // BoxCollider2D box = new_food.AddComponent<BoxCollider2D>();
        // box.isTrigger = true;
        //
        // Rigidbody2D rb = new_food.AddComponent<Rigidbody2D>();
        // rb.gravityScale = 0;
        //
        // SpriteRenderer sr = new_food.AddComponent<SpriteRenderer>();
        // // sr.sprite = sprite_for_all;
        //
        // int index = Random.Range(0, objectsArray.Length - 1);
        //
        // sr.sprite = objectsArray[index] as Sprite;
        
        new_food.transform.position = new Vector3(
            Mathf.Round(Random.Range(-26, 12)) + (float)0.5, 
            Mathf.Round(Random.Range(-31, 7)) + (float)0.5, -1f);
            
        foods.Add(new_food);
    }

    void Start()
    {
        count = 0;

        Spawn(6000);
    }

    void FixedUpdate()
    {

        if (foods.Count == 0)
        {
            Spawn(6000);
        }

        int i = 0;
        while (true)
        {
            GameObject food = foods[i];
            
            if (food.GetComponent<FoodType>().TTL <= 0)
            {
                foods.RemoveAt(i);
                Destroy(food);
                i = Mathf.Min(i - 1, 0);
            }

            i += 1;
            if (i >= foods.Count)
            {
                break;
            }
        }
    }
    
    private void OnTriggerEnter2D(Collider2D col) {
        if (col.CompareTag("Food"))
        {
            foods.Remove(col.GameObject());
            Destroy(col.GameObject());
        }
    }
}
