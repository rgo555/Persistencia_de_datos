using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Variables del awake
    private CharacterController controller;
    
    //Variables de movimiento
    [SerializeField]float speed;
    Vector3 velocity;
    [SerializeField]float smoothTimeMove;
    [SerializeField]float accelerationTime;
    float timePassed;

    //Variables Smooth rotacion
    [SerializeField]float turnSmoothTime;
    float turnSmoothVelocity;

    void Awake()
    {
        controller = GetComponent<CharacterController>();
        
    }

    void Start()
    {
        transform.position = new Vector3(PlayerPrefs.GetFloat("posX"), PlayerPrefs.GetFloat("posY"), PlayerPrefs.GetFloat("posZ"));
    
    }

    void Update()
    {
        Movement();
    }

    void Movement()
    {
        Vector3 move = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical")).normalized;
        
        if(move != Vector3.zero)
        {
            float x = 0;
            timePassed += Time.deltaTime;
            float acceleration = timePassed / accelerationTime; // Calculate the change in x over each unit of time

            x = Mathf.Lerp(0, 1, acceleration);

            float currentSpeed = Mathf.Lerp(0, speed, x); // Gradually increase the speed
            controller.Move(move.normalized * currentSpeed * Time.deltaTime);
        }
        else
        {
            timePassed = 0;
        }
    }
}
