using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desplazamiento_Horizontal : MonoBehaviour
{
	public bool canX;
	public float speed_X;
	public float amount_x;
	float m_internal_amount_x;
	public bool right;

	private void Start()
	{
		m_internal_amount_x = amount_x;
	}

	private void Update()
	{
		if (canX)
		{
			MoveX();
		}
	}

	void MoveX()
	{
		if (right)
		{
			transform.Translate(Vector3.right * (speed_X * Time.deltaTime), Space.Self);
			amount_x -= Time.deltaTime;
			if (amount_x < m_internal_amount_x*-1)
			{
				right = false;
			}

		}
		else
		{
			transform.Translate(Vector3.left * (speed_X * Time.deltaTime), Space.Self);
			amount_x += Time.deltaTime;
			if (amount_x > m_internal_amount_x)
			{
				right = true;
			}
		}
	}
}
