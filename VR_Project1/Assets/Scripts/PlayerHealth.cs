using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    
    public int maxHealth = 100;
    private int currHealth;
    public GameObject healthBarUi;
    public Slider slider;
    public GameObject redOverlay;
 
 

    // Start is called before the first frame update
    void Start()
    {
        currHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = (float)currHealth / maxHealth;

        if (currHealth > maxHealth) {
            currHealth = maxHealth;
        }
    }

    public float CalculateHealth() {
        return (float)currHealth / maxHealth;
    }

    public void takeDamage(int damage)
    {

        currHealth -= damage;


        if (currHealth <= 20)
        {
            redOverlay.SetActive(true);
        }
        else
        {
            redOverlay.SetActive(false);
        }
    }

    public void healDamage(int damage)
    {
        currHealth += damage;
        if (currHealth > maxHealth)
        {
            currHealth = maxHealth;
        }
    }
}

