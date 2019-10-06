using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Howl : MonoBehaviour
{
    private AudioSource source;

	public AudioClip howl;
	public AudioClip silence;

	private void Start()
	{
		source = GetComponent<AudioSource>();


	}

	private void Update()
	{
		if(Input.GetMouseButtonDown(0)){
			source.clip = howl;
			source.Play();
		}

		if(Input.GetMouseButtonUp(0))
		{
			source.clip = silence;
			source.Play();
		}
	}
}
