using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChange : MonoBehaviour
{
    bool position = false;
    private SpriteRenderer spriteR;
    public Sprite[] sprites;

    // Start is called before the first frame update
    void Start()
    {
        spriteR = gameObject.GetComponent<SpriteRenderer>();
        InvokeRepeating("SwitchSprite", .25f, .25f);
    }

    void SwitchSprite(){
        if (position){
            spriteR.sprite = sprites[0];
            position = false;
            //print("here");
        }else{
            spriteR.sprite = sprites[1];
            position = true;
            //print("not");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
