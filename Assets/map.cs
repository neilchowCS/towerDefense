using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map : MonoBehaviour
{

  public int playerHealth;
  public int playerMoney;

	public float[] mapPoints = new float[] {-7f, 2.1f, -7.5f, 0.5f, -6.2f,
     -0.4f, -5f, -0.1f, 3f, 4.4f, 4.5f, 4.1f, 4.4f, 2.4f, 2f, 0.9f,
      -3f, -2.3f, -2.9f, -3.3f, -2f, -3.5f, 3f, -1.1f, 6f, 0.4f, 7f,
       0.5f, 7.4f, 
		-0.6f, 6.2f, -3f, 8.8f, -5.1f};

  public float[] towerPoints = new float [] {
    -5.5f, 1.3f, -3.2f, 2.6f, -0.7f, 4f, -0.7f, 0.7f, 2.3f, 2.5f, -4f,
    -1.4f, 1.5f, -0.95f, 6f, 2.3f, 4.5f, -2.35f
  };

    // Start is called before the first frame update
    void Start()
    {
        playerMoney = 0;
        playerHealth = 20;
        print(towerPoints.Length);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
