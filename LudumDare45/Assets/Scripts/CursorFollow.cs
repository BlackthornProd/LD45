using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorFollow : MonoBehaviour
{
	private void Start()
	{
		Cursor.visible = false;
	}

	private void Update()
	{
		transform.position = Input.mousePosition;

		if(Input.GetMouseButtonDown(0)){
			transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
		}

		if(Input.GetMouseButtonUp(0))
		{
			transform.localScale = new Vector3(1, 1, 1);
		}
	}
}
