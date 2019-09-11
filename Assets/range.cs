using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class range : MonoBehaviour
{
	private double range1 = 1f;
	private float factor;
	private float angleTheta;
	private List<int> integerRange = new List<int>();
	public Texture2D rangeTex;

	public float GetRadius(float theta){
		double cosine = Math.Cos(theta * Math.PI/180.0) * 180.0/Math.PI;
		double sine = Math.Sin(theta * Math.PI/180.0) * 180.0/Math.PI;

		//print(cosine);
		//print(sine);

		float output = ((float)Math.Sqrt(range1 / (cosine * cosine + sine * sine)));
        return(output*300);

	}
    // Start is called before the first frame update
    void Start()
    {
    	for (int i = 0; i < 360; i++){
    		integerRange.Add(i);
    	}

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI()
    {
    	//angleTheta = this.GetComponent<targeting>().angle;
        //print(GetRadius(angleTheta));
        //foreach (var value in integerRange) {
            float value = 180f;
    		float radius = GetRadius(value);
    		Vector2 location = this.gameObject.GetComponent<targeting>().location;
            //GUIUtility.RotateAroundPivot(value, location);
            //GUI.DrawTexture(new Rect(location.x-5, location.y-5, radius*75f, 10f), rangeTex);
    	//}
            
        
}
    
}
