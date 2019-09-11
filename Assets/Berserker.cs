using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Berserker : Enemy
{
    private float speed;
    private int count1;
    private float health;
    private float maxHealth;
    private int damage;

    // Start is called before the first frame update
    private void Berserk(){
    	health -= 3f;
    	speed += 0.2f;
    }


    void Start()
    {
    	speed = 1.5f;
    	count1 = 0;
        maxHealth = 100f;
        health = maxHealth;
        damage = 2;
        InvokeRepeating("Berserk", 1f, 1f);
        //health = 51f;
        //Vector3 starting = new Vector3(-1f, 5.7f, 0f);
        //transform.position = starting;
    }

    // Update is called once per frame
    void Update()
    {
        if(pathing(speed, count1, damage)){
        	count1++;
        }
    }

    void OnGUI(){
        makeHealthBar(health,maxHealth);
    }
}
