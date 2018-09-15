using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_Personaje_cámara : MonoBehaviour
{
    public float velocidad;
    public float rotateSpeed = 3.0F;
    public float rot_X;
    public GameObject cam;
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
    { 
        transform.Rotate(0, Input.GetAxis("Mouse X") * rotateSpeed, 0);
        rot_X += (Input.GetAxis("Mouse Y") * -1) * rotateSpeed;

        if ( rot_X > 0 && rot_X < 60)
        {
            cam.transform.localRotation = Quaternion.Euler(rot_X, 0, 0);
        }
        if (rot_X < 0 && rot_X > -60)
        {
            cam.transform.localRotation = Quaternion.Euler(rot_X, 0, 0);
        }
        if (rot_X > 60)
        {
            rot_X = 60;
        }
        if (rot_X < -60)
        {
            rot_X = -60;
        }
        Vector3 move = transform.TransformDirection(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")));
        controller.SimpleMove(move * velocidad);

    }

}
