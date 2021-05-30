using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

	//GUI�Ő�����ύX�ł���悤�ɂ��邽��,public���g��
	public float speed;

	// Start�֐��͊J�n����1�x�����Ăяo�����֐�
	void Start()
	{
		//float�̏ꍇ�͐�����f��ǉ�����
		speed = 15.0f;
		GetComponent<Rigidbody>().AddForce((transform.right - transform.up) * speed,
			ForceMode.VelocityChange);
	}

    void Update()
    {
		GetComponent<Rigidbody>().velocity =
			GetComponent<Rigidbody>().velocity.normalized * speed;
    }
}