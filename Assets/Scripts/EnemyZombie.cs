using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemyZombie : MonoBehaviour
{

    public Transform target;
    private float distance;
    private NavMeshAgent MyAgent;
    private Animator MyAnim;
    void Start()
    {
        MyAnim = GetComponent<Animator>();
        MyAgent = GetComponent<NavMeshAgent>();
    }

    
    void Update()
    {
        distance = Vector3.Distance(transform.position, target.transform.position);
        if (distance> 10)
        {
            MyAgent.enabled = false;
            MyAnim.SetBool("idle",true);
            MyAnim.SetBool("run",false);
            MyAnim.SetBool("attack",false);
        }
        
        if (distance <= 10 & distance > 1.5f)
        {
            MyAgent.enabled = true;
            MyAgent.SetDestination((target.position));
            MyAnim.SetBool("run",true);
            MyAnim.SetBool("idle",false);
            MyAnim.SetBool("attack",false);
        }
        
        if (distance <= 1.5f )
        {
            MyAgent.enabled = false;
            MyAnim.SetBool("attack",true);
            MyAnim.SetBool("idle",false);
            MyAnim.SetBool("run",false);
            
        }
    }
}
