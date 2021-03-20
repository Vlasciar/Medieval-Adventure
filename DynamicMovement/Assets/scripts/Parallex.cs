using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallex : MonoBehaviour
{

	private float length, startPosX, startPosY;
	public GameObject cam;
	public float parallexEffect;

	void Start()
	{
		startPosX = transform.position.x;
		startPosY = transform.position.y;
		length =  GetComponent<SpriteRenderer>().bounds.size.x;
	}

	void FixedUpdate()
	{
		float temp = (cam.transform.position.x * (1 - parallexEffect));
		float dist = (cam.transform.position.x * parallexEffect);

		transform.position = new Vector3(startPosX + dist, startPosY, transform.position.z);

		if (temp > startPosX + length) startPosX += 2*length;
		else if (temp < startPosX - length) startPosX -= 2*length;
	}

}
