using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    bool inRefuelArea = false;
    UnityEngine.Collision player;

    float timer;
    int waitingTime = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inRefuelArea)
        {
            timer += Time.deltaTime;
            if (timer > waitingTime)
            {
                player.gameObject.GetComponent<PlayerHealth>().healDamage(25);
                timer = 0;
            }
            
        }
    }
        
    

    private void OnCollisionEnter(UnityEngine.Collision player)
    {
        if (player.gameObject.tag == "Player") inRefuelArea = true;
    }

    private void OnCollisionExit(UnityEngine.Collision player)
    {
        if (player.gameObject.tag == "Player") inRefuelArea = false;
    }
}
