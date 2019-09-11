using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
	private float speed1 = 10f;
	public GameObject projectileTarget;
    private float damage = 25f;

	public void move(float x, float y){
        Vector3 destination = new Vector3(x,y,transform.position.z);
        float step =  speed1 * Time.deltaTime;
    	transform.position = Vector3.MoveTowards(transform.position, destination, step);
    }

    public void CheckArrive(float x, float y){
        if (transform.position == new Vector3(x, y, transform.position.z)){
            DealDamage(damage);
            Destroy(this.gameObject);
        }
    }

    public void DealDamage(float damage){
        projectileTarget.GetComponent<Marshmallow>().TakeDamage(damage);
        //print("here");
    }

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        //print(projectileTarget.transform.position.x);
        if (projectileTarget != null){
            move(projectileTarget.transform.position.x,projectileTarget.transform.position.y);
            CheckArrive(projectileTarget.transform.position.x,projectileTarget.transform.position.y);
        }else{
            Destroy(this.gameObject);
        }
        
    }
}
