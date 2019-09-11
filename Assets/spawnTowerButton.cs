using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnTowerButton : MonoBehaviour
{
	public GameObject obj;
    public GameObject canvas;
	public List<GameObject> towerLocationList;
    // Start is called before the first frame update
    void Start()
    {
        float[] points = this.gameObject.GetComponent<map>().towerPoints;
        print(points.Length);
        int numTowers = (points.Length)/2;
        int count = 0;
        while (count < numTowers){
        	float x = points[count*2];
        	float y = points[count*2+1];
        	GameObject temp = (GameObject)Instantiate(obj);
        	//temp.SetActive(true);
            temp.transform.SetParent(canvas.GetComponent<Transform>());
            temp.transform.position = (new Vector3((temp.transform.position.x+709.5f)+(710f*x/9.8f), (temp.transform.position.y+399f)+(400f*y/5.4f), 0f));
            temp.GetComponent<spawnTower>().towerPlacement = new Vector3(x, y, -0.01f);
            towerLocationList.Add(temp);
        	count++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
