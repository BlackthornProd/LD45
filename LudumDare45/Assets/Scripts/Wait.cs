using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wait : MonoBehaviour
{
    public float wait;

	public GameObject sun;
	public Transform pos;

	private Animator camAnim;

	bool once;

	private void Start()
	{
		camAnim = Camera.main.GetComponent<Animator>();
	}

	private void Update()
	{
		if (Input.GetMouseButton(0))
		{
			wait -= Time.deltaTime;

		}

		if(wait <= 0){
			if (once == false)
			{
				camAnim.SetTrigger("shake");
				Instantiate(sun, pos.position, Quaternion.identity);
				once = true;
			}
			
		}
	}
}
