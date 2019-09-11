using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marshmallow : Enemy
{
    private float speed;
    private int count1;
    private float health;
    private float maxHealth;
    private int ID;
    private int damage;
    private int worth;

    // Start is called before the first frame update

    public void TakeDamage(float damage){
        health -= damage;
        //print(health);
    }

    void Start()
    {
    	speed = 1.5f;
    	count1 = 0;
        maxHealth = 100f;
        health = maxHealth;
        damage = 2;
        worth = 20;
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
        CheckHealth(health, worth);
    }

    void OnGUI(){
        makeHealthBar(health,maxHealth);
    }
}
