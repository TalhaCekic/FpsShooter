using System.IO;
using UnityEngine;
using UnityEngine.AI;

public class run : MonoBehaviour
{

    private NavMeshAgent dusman;

    public GameObject playerr;
    
    public Animator anim;

    private void Start()
    {
        dusman = GetComponent<NavMeshAgent>();


    }
    void Update()
    {

        dusman.SetDestination(playerr.transform.position);
            anim.SetBool("end", true);

       



    }

}
