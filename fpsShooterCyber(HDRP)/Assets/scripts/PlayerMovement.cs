using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerMovement : MonoBehaviour
{
   public CharacterController CharacterController;
    public float speed = 12f;
    public float jumpHeight = 3f;
    public float health = 250;
    public Text Health; 

    Vector3 velocity;
    public float gravity = -9.81f;
    public bool isGround;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
   
    void Update()
    {
        isGround = Physics.CheckSphere(groundCheck.position, groundDistance,groundMask) ;

        if(isGround && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        CharacterController.Move(move* speed *Time.deltaTime);

        if (Input.GetButtonDown("Jump") &&  isGround)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
        velocity.y += gravity * Time.deltaTime;
        CharacterController.Move(velocity* Time.deltaTime);
        Health.text = health.ToString();
    }
    public void OnTriggerStay(Collider Player)
    {
        if(Player.gameObject.tag == "target")
        {
            health -=1;
            if (health < 0)
            {
                SceneManager.LoadScene(1);
            }
        }
    }
}
