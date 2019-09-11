using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{

	public int playerHealth;
    public int playerMoney;
    public Text playerHealthText;
    public Text playerMoneyText;

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = 20;
        playerMoney = 0;
        if (playerHealthText != null && playerMoneyText != null){
            playerHealthText.text = ""+playerHealth;
            playerMoneyText.text = ""+playerMoney;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI()
    {
        
    }
}
