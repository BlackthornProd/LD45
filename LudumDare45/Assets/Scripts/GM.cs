using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour
{
    public int numOfFans;

	public GameObject sun;
	public Transform pos;

	bool once;

	public void Decrease(){
		numOfFans--;
	}

	public void Update()
	{
		if(numOfFans <= 0){
			if(once == false){
				Instantiate(sun, pos.position, Quaternion.identity);
				once = true;
			}
			

		}
	}

}
