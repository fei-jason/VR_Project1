using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    
   public int maxHealth = 100;
   private int currHealth;
   public GameObject redOverlay;

    // Start is called before the first frame update
    void Start()
    {
        currHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {        
        CalculateHealth();
        
        if (currHealth > maxHealth) {
            currHealth = maxHealth;
        }
    }

    public float CalculateHealth() {
        return (float)currHealth / maxHealth;
    }

    public void takeDamage(int damage){
        
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

   /* private void OnCollisionEnter(Collision collision){

        if(collision.gameObject.tag == "Bullet"){
            collision.gameObject.GetComponent<PlayerHealth>().takeDamage(25);
        
        }
    } */
}

