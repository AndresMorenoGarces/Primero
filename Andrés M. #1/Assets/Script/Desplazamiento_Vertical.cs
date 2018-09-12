using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desplazamiento_Vertical : MonoBehaviour
{
	public bool canY;
	public float speed_y;
	public float amount_y;
	float m_internal_amount_y;
	public bool up;

	private void Start()
	{
		m_internal_amount_y = amount_y;
	}

	private void Update()
	{
		if (canY)
		{
			MoveY();
		}
	}

	void MoveY()
	{
		if (up)
		{
			transform.Translate(Vector2.up * (speed_y * Time.deltaTime), Space.Self);
			amount_y -= Time.deltaTime;
			if (amount_y < m_internal_amount_y * -1)
			{
				up = false;
			}

		}
		else
		{
			transform.Translate(Vector2.down * (speed_y * Time.deltaTime), Space.Self);
			amount_y += Time.deltaTime;
			if (amount_y > m_internal_amount_y)
			{
				up = true;
			}
		}
	}
}
