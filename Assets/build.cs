using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class build : MonoBehaviour
{
    //public List<GameObject> towerListToSetActive;

	public void ShowMenu(){
		//print(transform.position.z);
		if (transform.position.z == 1){
			transform.position = new Vector3(transform.position.x, transform.position.y, -.2f);
            foreach (var location in GameObject.Find("map").GetComponent<spawnTowerButton>().towerLocationList){
                location.SetActive(true);
            }
		}else{
			transform.position = new Vector3(transform.position.x, transform.position.y, 1f);
            foreach (var location in GameObject.Find("map").GetComponent<spawnTowerButton>().towerLocationList){
                location.SetActive(false);
            }
		}
	}
    // Start is called before the first frame update
    void Start()
    {
        //GameObject.Find("menu").transform.position = new Vector3(GameObject.Find("menu").transform.position.x, GameObject.Find("menu").transform.position.y, -0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
