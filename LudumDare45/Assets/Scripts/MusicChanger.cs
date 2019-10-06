using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicChanger : MonoBehaviour
{
    private AudioSource music;
	public AudioClip clipy;

	private void Start()
	{
		music = GameObject.FindGameObjectWithTag("Music").GetComponent<AudioSource>();
		if(music.clip != clipy)
		{
			music.clip = clipy;
			music.Play();
		}
	}

}
