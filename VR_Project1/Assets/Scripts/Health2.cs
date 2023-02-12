using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health2 : MonoBehaviour
{

    public int maxHealth = 100;
    private int currHealth;

    public GameObject healthBarUi;
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        currHealth = maxHealth;
        slider.value = (float)currHealth / maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        //slider.value = currHealth;

        if (currHealth < maxHealth) {
            healthBarUi.SetActive(true);
        }

        if (currHealth > maxHealth) {
            currHealth = maxHealth;
        }
    }

    public float CalculateHealth() {
        return (float)currHealth / maxHealth;
    }

    public void takeDamage(int damage){
        
        currHealth -= damage;
        slider.value = currHealth / maxHealth;
        
        if (currHealth <= 0){
            Destroy(gameObject);
        }
    }
}
