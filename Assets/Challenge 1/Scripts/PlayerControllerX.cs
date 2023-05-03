using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float MAX_SPEED = 40f;
    private float MIN_SPEED = 0F;

    public float speed;
    public float rotationSpeed = 40f;
    public float verticalInput, horizontalInput;
    public bool turn;
    public bool accelerator, brake;
        
    [SerializeField]
    private GameObject propellor;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Inputs de usuario
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        accelerator = Input.GetButton("Accelerate");
        brake = Input.GetButton("Brake");

        // Acelerador gradual hasta velocidad maxima
        if (accelerator && (speed < MAX_SPEED))
        {
            speed += 0.5f;
                        
        }        

        // Freno gradual hasta velocidad 0
        if (brake && (speed > MIN_SPEED))
        {
            speed -= 0.5f;
            
        }

        transform.Translate(speed * Time.deltaTime * Vector3.forward);

        // Inclina el avion arriba/abajo
        
        transform.Rotate(rotationSpeed * Time.deltaTime * Vector3.right * verticalInput );

        // Girar el avion a izq/der

        transform.Rotate(rotationSpeed * Time.deltaTime * Vector3.back * horizontalInput);

        // Girar helice

        propellor.transform.Rotate(speed * Vector3.forward);

    }
}
