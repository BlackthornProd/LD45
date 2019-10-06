using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sun : MonoBehaviour
{

	private Animator fadePanel;
	private Animator camAnim;

	public GameObject effect;


	private void Start()
	{
		camAnim = Camera.main.GetComponent<Animator>();
		fadePanel = GameObject.FindGameObjectWithTag("FadePanel").GetComponent<Animator>();
	}
	private void OnTriggerEnter2D(Collider2D other)
	{
		if(other.CompareTag("Player") || other.CompareTag("PlayerTwo")){
			Destroy(other.gameObject);
			Instantiate(effect, transform.position, Quaternion.identity);
			StartCoroutine(NewScene());
		}
	}

	IEnumerator NewScene(){
		camAnim.SetTrigger("shake");
		fadePanel.SetTrigger("fadeIn");
		yield return new WaitForSeconds(1.5f);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
