using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
	[SerializeField]
	private float xMax;

	[SerializeField]
	private float yMax;

	[SerializeField]
	private float yMin;

	[SerializeField]
	private float xMin;

	private Transform target;
	// Use this for initialization
	void Start()
	{
		target = GameObject.Find("player").transform;
	}

	// Update is called once per frame
	void LateUpdate()
	{
		transform.position = new Vector3(Mathf.Clamp(target.position.x, xMin, xMax), Mathf.Clamp(target.position.y, yMin, yMax), transform.position.z);
	}
}
