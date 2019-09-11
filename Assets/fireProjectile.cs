using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireProjectile : MonoBehaviour
{
	public GameObject obj;
    private float rateOfFire = 1f;
    private float timer = 0f;
	//public GameObject projectileTarget;

	public void spawn(){
		GameObject temp = (GameObject)Instantiate(obj);
        temp.SetActive(true);
        temp.transform.position = transform.position;
        temp.GetComponent<Projectile>().projectileTarget = this.GetComponent<targeting>().target;
	}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	//print(projectileTarget);
        timer += Time.deltaTime;
        if (timer >= rateOfFire){
            timer = 2f;
            if (this.GetComponent<range>().GetRadius(this.GetComponent<targeting>().angle - 90f) >= this.GetComponent<targeting>().distance){
                //print(this.GetComponent<range>().GetRadius(this.GetComponent<targeting>().angle - 90f));
                spawn();
                timer = 0f;
            }
        }
    	

    }
}
