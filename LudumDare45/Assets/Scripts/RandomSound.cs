using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSound : MonoBehaviour
{
	private AudioSource source;
	public AudioClip[] clips;

	private void Start()
	{
		source = GetComponent<AudioSource>();
		int randSound = Random.Range(0, clips.Length);
		source.clip = clips[randSound];
		source.Play();
	}

	
}
