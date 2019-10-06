using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TheHowler : MonoBehaviour
{

	private SpriteRenderer rend;
	public Sprite good;
	public Sprite bad;

	public GameObject twirl;

	public Camera cam;
	public Color goodColor;
	public Color badColor;

	public Color titleColor;
	public SpriteRenderer title;
	private float timeBtwAlpha;

	public Animator fadePanel;

	public float waiter;

	public bool isLast;
	private void Start()
	{
		rend = GetComponent<SpriteRenderer>();
	}

	private void Update()
	{
		if(Input.GetMouseButtonDown(0)){
			
			rend.sprite = bad;
			cam.backgroundColor = badColor;
			twirl.SetActive(true);
		}

		if(Input.GetMouseButton(0))
		{
			if(timeBtwAlpha <= 0){
				titleColor.a += 0.05f;
				title.color = titleColor;
				timeBtwAlpha = waiter;
			} else {
				timeBtwAlpha -= Time.deltaTime;
			}	
		}

		if(titleColor.a >= 1){
			StartCoroutine(NewScene());
		}

		if (Input.GetMouseButtonUp(0))
		{
			rend.sprite = good;
			cam.backgroundColor = goodColor;
			twirl.SetActive(false);
		}

	}

	IEnumerator NewScene(){
		fadePanel.SetTrigger("fadeIn");
		yield return new WaitForSeconds(1.5f);
		if(isLast == true){
			SceneManager.LoadScene("BTP");
		} else {
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
		
	}

}
