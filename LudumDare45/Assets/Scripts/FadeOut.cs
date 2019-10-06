using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour
{
    private Animator anim;

	private void Start()
	{
		anim = GetComponent<Animator>();
	}

	private void Update()
	{
		if(Input.GetMouseButtonDown(0)){
			anim.SetTrigger("fadeOut");
		}
	}
}
