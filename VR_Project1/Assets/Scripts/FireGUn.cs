using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class FireGUn : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPoint;
    public float fireSpeed = 20f;

    public SteamVR_Action_Boolean grabPinch; //Grab Pinch is the trigger, select from inspecter
    public SteamVR_Input_Sources inputSource = SteamVR_Input_Sources.RightHand;//which controller

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void FireBullet()
    {
        GameObject spawnBullet = Instantiate(bullet);
        spawnBullet.transform.position = spawnPoint.position;
        spawnBullet.transform.rotation = spawnPoint.rotation;
        spawnBullet.GetComponent<Rigidbody>().velocity = fireSpeed * spawnBullet.transform.forward;
        Destroy(spawnBullet, 5);
    }
}
