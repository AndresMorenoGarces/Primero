using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class PlayerMovement : MonoBehaviour
{
    public float velocidad;
    public float rotateSpeed = 3.0F;
    CharacterController controller;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    void Update()
    {
            Movimiento();
    }

    public void Movimiento()
    { //Movimiento del personaje
            transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);
            Vector3 forward = transform.TransformDirection(Vector3.forward);
            float curSpeed = velocidad * Input.GetAxis("Vertical");
            controller.SimpleMove(forward * curSpeed);

    }
    
}
    


