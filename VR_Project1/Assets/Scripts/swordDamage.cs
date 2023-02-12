using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordDamage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(UnityEngine.Collision swordHit){
        if(swordHit.gameObject.tag == "Enemy"){
            swordHit.gameObject.GetComponent<Health2>().takeDamage(25);
        }
    }
}
