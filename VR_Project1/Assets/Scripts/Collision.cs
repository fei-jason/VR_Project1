using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    GameObject enemy;
    Collider Bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {

    }

    private void OnCollisionEnter(UnityEngine.Collision bulletHit){
        if(bulletHit.gameObject.tag == "Player"){
            bulletHit.gameObject.GetComponent<PlayerHealth>().takeDamage(10);
        }

        if(bulletHit.gameObject.tag == "Enemy"){
            bulletHit.gameObject.GetComponent<Health2>().takeDamage(50);
        }
    }

}
