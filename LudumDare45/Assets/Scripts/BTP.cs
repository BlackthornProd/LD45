using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BTP : MonoBehaviour
{
    public Animator fadePanel;

	public float waitTime;

	private void Update()
	{
		if(waitTime <= 0){
			StartCoroutine(Title());
		} else {
			waitTime -= Time.deltaTime;
		}
	}

	IEnumerator Title(){
		fadePanel.SetTrigger("fadeIn");
		yield return new WaitForSeconds(1.5f);
		SceneManager.LoadScene("Title");
	}
}
