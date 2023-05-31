using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class targets : MonoBehaviour
{
    public float health = 20f;

    private NavMeshAgent dusman;

    public GameObject playerr;

    public Animator anim;
    

  
    public void Start()
    {
        playerr = GameObject.FindWithTag("Player");
        dusman = GetComponent<NavMeshAgent>();
        dusman.SetDestination(playerr.transform.position);
    }

    public void Update()
    {
        dusman.SetDestination(playerr.transform.position);
    }
    public void takeDamage(float damage)
    {
        health -= damage;
        if(health > 5)
        {
dusman.SetDestination(playerr.transform.position);
        }
        if( health < 0)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject,5);
        dusman = null;
        this.GetComponent<BoxCollider>().enabled = false;
 anim.SetBool("end", true);
        
    }
}
