using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public GameObject healthBarUi;
    public Slider slider;

    // Start is called before the first frame update
    void Start() {
        currentHealth = maxHealth;
        slider.value = CalculateHealth();
    }

    void Update() {
        slider.value = CalculateHealth();
        
        if (currentHealth < maxHealth) {
            // healthBarUi.SetActive(true);
        }

        if (currentHealth <= 0) {
            // Destroy();
        }

        if (currentHealth > maxHealth) {
            currentHealth = maxHealth;
        }
    }

    float CalculateHealth() {
        return (float)currentHealth / maxHealth;
    }
}
