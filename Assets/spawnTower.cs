using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnTower : MonoBehaviour
{
	public GameObject obj;
    private bool towerExist;
    public Vector3 towerPlacement;

	public void spawn(){
        if (!towerExist){
            GameObject temp = (GameObject)Instantiate(obj);
            temp.SetActive(true);
            temp.transform.position = towerPlacement;
            //print(temp.GetComponent<idcounter>().ID);
            //print(GameObject.Find("map").GetComponent<enemyList>().list.Count);
            towerExist = true;
            this.gameObject.SetActive(false);
        }
	}
    // Start is called before the first frame update
    void Start()
    {
        towerExist = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
