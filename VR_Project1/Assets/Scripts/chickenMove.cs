using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class chickenMove : MonoBehaviour
{

    private Transform player;

    private NavMeshAgent chicken;



    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;

        chicken = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player);

        chicken.SetDestination(player.transform.position);
    }
}
