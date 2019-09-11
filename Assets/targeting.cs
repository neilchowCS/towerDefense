using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class targeting : MonoBehaviour
{
	public List<GameObject> list;
	public Texture2D lineTex;
    public GameObject target;
	public float distance;
	public float angle;
    public Vector2 location;
    public Camera cam;
    // Start is called before the first frame update
    public float NewDist(float x, float y, float x1, float y1){
        float output = (float)Math.Sqrt((x-x1)*(x-x1)+(y-y1)*(y-y1));
        return output;
    }

    public float NewAngle(float x, float y, float x1, float y1){
        return 0f;
    }

    public GameObject GetTarget(){
        return target;
    }


    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnGUI(){
        list = GameObject.Find("map").GetComponent<enemyList>().list;
        if (list.Count != 0){
            //print(list[0].transform.position);
            int i = 0;
            target = list[0];
            while(this.GetComponent<range>().GetRadius(Vector2.SignedAngle(Vector2.right, target.transform.position) - 90f) < Vector3.Distance(transform.position,target.transform.position) && i < list.Count -1)
            {
                target = list[i];
                i++;
            }
            if (this.GetComponent<range>().GetRadius(Vector2.SignedAngle(Vector2.right, target.transform.position) - 90f) >= Vector3.Distance(transform.position,target.transform.position))
            {
                distance = Vector3.Distance(transform.position,target.transform.position);
                Vector3 guicoord = cam.ScreenToWorldPoint(transform.position);
                //distance = NewDist(transform.position.x - Screen.width/2)
                //print(distance);
                location = new Vector2((transform.position.x +9.6f)*74, (-transform.position.y +5.4f)*74f);
                angle = Vector2.SignedAngle(Vector3.right, new Vector2(target.transform.position.x - transform.position.x, target.transform.position.y - transform.position.y));
                print(angle);
                GUIUtility.RotateAroundPivot(-angle, location);
                GUI.DrawTexture(new Rect(location.x-5, location.y-5, distance*74f, 10f), lineTex);
                //print(location);
            }else{
                target = null;
            }
            
        }
    }
}
