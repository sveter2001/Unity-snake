using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body : MonoBehaviour
{
    public Sprite sprite1;
    public Sprite sprite2;
    public SpriteRenderer spriteRender;

    public void Body1(Sprite sprite1,Sprite sprite2,SpriteRenderer spriteRender){
        this.sprite1 = sprite1;
        this.sprite2 = sprite2;
        this.spriteRender = spriteRender;
    }

    private void Start()
    {
        spriteRender = GetComponent<SpriteRenderer>();
        if(spriteRender != null){
            spriteRender.sprite = sprite1;
        }
    }

    public void Turn(){
        
    }

}
