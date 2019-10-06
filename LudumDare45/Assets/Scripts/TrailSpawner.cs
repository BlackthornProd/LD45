using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailSpawner : MonoBehaviour
{
    public GameObject trail;

	private float timeBtwTrail;
	public float startTimeBtwTrail;

	private void Update()
	{
		Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
		if (moveInput != Vector2.zero){
			if (timeBtwTrail <= 0)
			{
				Instantiate(trail, transform.position, Quaternion.identity);
				timeBtwTrail = startTimeBtwTrail;
			}
			else
			{
				timeBtwTrail -= Time.deltaTime;
			}
		}
		
	}
}
