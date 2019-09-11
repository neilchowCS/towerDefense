using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnMarshmallow : Enemy
{
    // Start is called before the first frame update
    public GameObject obj;

	public void spawn(){
		GameObject temp = (GameObject)Instantiate(obj);
        temp.SetActive(true);
        temp.transform.position = transform.position;
        GameObject.Find("map").GetComponent<enemyList>().list.Add(temp);
        //print(temp.GetComponent<idcounter>().ID);
        //print(GameObject.Find("map").GetComponent<enemyList>().list.Count);
	}


    void Start()
    {
        InvokeRepeating("spawn", 2f, 2f);
        //spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
