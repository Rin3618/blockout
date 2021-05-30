using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar : MonoBehaviour
{
	int accel;
	// Use this for initialization
	void Start()
	{
		accel = 50;
	}

	// Update is called once per frame
	void Update()
	{
		GetComponent<Rigidbody>().AddForce(transform.right * Input.GetAxisRaw("Horizontal") * accel, ForceMode.Impulse);
	}
}