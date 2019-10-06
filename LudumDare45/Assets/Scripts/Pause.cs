using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{

			Time.timeScale = 0;
		}
	}
}
