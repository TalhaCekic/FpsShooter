using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{

    public float damage = 10f;
    public float range = 100f;

    public ParticleSystem muzzle;
    public AudioSource fire;
    public GameObject fpsCam;
    public Text skor;
    public float kill;

    void Update()
    {
        
        Debug.DrawRay(fpsCam.transform.position, fpsCam.transform.forward * range, Color.red);
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
            muzzle.Play();
            fire.Play();
        }
    }
    void Shoot()
    {
        RaycastHit hit;
        
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            targets Target = hit.transform.GetComponent<targets>();
            skor.text = kill.ToString();
            if(Target != null)
            {
                Target.takeDamage(damage);
                if(Target.health < 0)
                {
                    kill +=1;
                }
                
            }
        }
    }
}
