using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpDisplay : MonoBehaviour
{
    private int health = 50;
    public Text healthText;

    void Update()
    {
        healthText.text = "HP : " + health;
        if(Input.GetKeyDown(KeyCode.Space))
        {
            health--;
        }
    }
}
