using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    
   public int maxHealth = 100;
   private int currHealth;

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
        
        if (currHealth <= 0){
            Destroy(gameObject);
        }
    }

   /* private void OnCollisionEnter(Collision collision){

        if(collision.gameObject.tag == "Bullet"){
            collision.gameObject.GetComponent<PlayerHealth>().takeDamage(25);
        
        }
    } */
}

