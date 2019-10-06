using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBGColor : MonoBehaviour
{
    private Camera cam;
	public Color normal;
	public Color drama;

	private void Start()
	{
		cam = Camera.main.GetComponent<Camera>();
	}

	private void Update()
	{
		if(Input.GetMouseButtonDown(0)){
			cam.backgroundColor = drama;
		}

		if (Input.GetMouseButtonUp(0)){
			cam.backgroundColor = normal;
		}
	}
}
