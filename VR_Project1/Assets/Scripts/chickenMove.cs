using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class chickenMove : MonoBehaviour
{

    private Transform player;
    private NavMeshAgent chicken;
    public LayerMask whatIsPlayer;


    //Patroling
    public float range; //radius of sphere
    public Transform centrePoint; //centre of the area the agent wants to move around in
    //States
    public float sightRange, attackRange;
    public bool playerInSightRange, playerInAttackRange;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        chicken = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        //Check for sight and attack range
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);
        
        if(!playerInSightRange && !playerInAttackRange) {
            PatrolPlayer();
        } else if (playerInSightRange && !playerInAttackRange) {
            ChasePlayer();
        } else if (playerInSightRange && playerInAttackRange) {
            AttackPlayer();
        }

    }

    private void PatrolPlayer() {
        if(chicken.remainingDistance <= chicken.stoppingDistance) //done with path
        {
            Vector3 point;
            if (RandomPoint(chicken.transform.position, range, out point)) //pass in our centre point and radius of area
            {
                // Debug.DrawRay(point, Vector3.up, Color.blue, 1.0f); //so you can see with gizmos
                chicken.SetDestination(point);
            }
        }
    }

    bool RandomPoint(Vector3 center, float range, out Vector3 result)
    {

        Vector3 randomPoint = center + Random.insideUnitSphere * range; //random point in a sphere 
        NavMeshHit hit;
        if (NavMesh.SamplePosition(randomPoint, out hit, 1.0f, NavMesh.AllAreas)) //documentation: https://docs.unity3d.com/ScriptReference/AI.NavMesh.SamplePosition.html
        { 
            //the 1.0f is the max distance from the random point to a point on the navmesh, might want to increase if range is big
            //or add a for loop like in the documentation
            result = hit.position;
            return true;
        }

        result = Vector3.zero;
        return false;
    }

    private void ChasePlayer()
    {
        
        chicken.SetDestination(player.position);
    }

    private void AttackPlayer() {
        chicken.SetDestination(transform.position);
    }

}
