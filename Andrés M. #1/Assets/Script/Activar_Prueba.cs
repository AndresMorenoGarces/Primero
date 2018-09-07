using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activar_Prueba : MonoBehaviour
{
    public GameObject prueba;

	private void Start ()
    {
        prueba.SetActive(false);
	}

    private void OnTriggerEnter(Collider sensor)
    {
        if (sensor.transform.tag == "Player")
        {
            prueba.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider sensor)
    {
        if (sensor.transform.tag == "Player")
        {
            prueba.SetActive(false);
        }
    }
     
}

