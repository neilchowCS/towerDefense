using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Texture2D emptyTex;
    public Texture2D fullTex;
    public Vector2 size = new Vector2(40,10);

    //private float[] map1;

    // Start is called before the first frame update
    void Start()
    {
    }

    public void move(float x, float y, float speed1){
        Vector3 destination = new Vector3(x,y,transform.position.z);
        float step =  speed1 * Time.deltaTime;
    	transform.position = Vector3.MoveTowards(transform.position, destination, step);
    }

    public float[] findmap(){
        return(GameObject.Find("map").GetComponent<map>().mapPoints);
    }

    public bool pathing(float speed1, int count, int damage){
        float[] points = findmap();
        int numMarkers = (points.Length)/2;
        if (count < numMarkers){
            float x = points[count*2];
            float y = points[count*2+1];
            move(x, y, speed1);
            Vector3 targetPosition = new Vector3(x,y,transform.position.z);
            if (transform.position == targetPosition){
                return(true);
            }else{
                return(false);
            }
        }
        GameObject.Find("map").GetComponent<enemyList>().list.Remove(this.gameObject);
        GameObject.Find("map").GetComponent<HUD>().playerHealth -= damage;
        GameObject.Find("map").GetComponent<HUD>().playerHealthText.text = ""+GameObject.Find("map").GetComponent<HUD>().playerHealth;
        Destroy(this.gameObject);
        return(false);

    }

    public void makeHealthBar(float health, float maxHealth) {
            Camera cam =GameObject.Find("Main Camera").GetComponent<Camera>();
            Vector3 screenPos = cam.WorldToScreenPoint(transform.position);
            GUI.DrawTexture(new Rect(screenPos.x-20f,750f - screenPos.y, size.x, size.y), emptyTex);
            GUI.DrawTexture(new Rect(screenPos.x-20f,750f - screenPos.y, size.x*(health/maxHealth), size.y), fullTex);
            
            
     }

     public void CheckHealth(float health, int worth){
        if (health <= 0f){
            GameObject.Find("map").GetComponent<enemyList>().list.Remove(this.gameObject);
            GameObject.Find("map").GetComponent<HUD>().playerMoney += worth;
            GameObject.Find("map").GetComponent<HUD>().playerMoneyText.text = ""+GameObject.Find("map").GetComponent<HUD>().playerMoney;
            Destroy(this.gameObject);
        }
     }


     


    // Update is called once per frame
    void Update()
    {
        
    }

}
