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
        enemy = GameObject.Find("Chicken_Enemy");
        
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider collider)
    {
        Destroy(enemy);
    }

}
