using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Energy : MonoBehaviour
{
    public int maxEnergy = 100;
    public int currEnergy;



    // Start is called before the first frame update
    void Start() {
        currEnergy = maxEnergy;
    }

    void Update() {
        // slider.value = CalculateHealth();
        
        if (currEnergy < maxEnergy) {
            // healthBarUi.SetActive(true);
        }

        if (currEnergy <= 0) {
            // Destroy();
        }

        if (currEnergy > maxEnergy) {
            currEnergy = maxEnergy;
        }
    }

    // float CalculateHealth() {
    //     return (float)currentHealth / maxHealth;
    // }
}
