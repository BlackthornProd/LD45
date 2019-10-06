using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanTwo : MonoBehaviour
{
	private Transform player;

	bool isFan;

	private SpriteRenderer rend;
	public Sprite normal;
	public Sprite excited;

	public GameObject effect;

	private Animator camAnim;

	private GM gm;

	private Rigidbody2D rb;

	private void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GM>();
		camAnim = Camera.main.GetComponent<Animator>();
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
		rend = GetComponent<SpriteRenderer>();
	}

	private void Update()
	{
		if(Input.GetMouseButtonDown(0)){
			isFan = true;
		}

		if(Input.GetMouseButtonUp(0))
		{
			isFan = false;
		}

		if(isFan == true){
			rb.gravityScale = 1;
			rend.sprite = excited;
		} else {
			rb.gravityScale = 0.1f;
			rend.sprite = normal;
		}
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Player") && isFan == true)
		{
			gm.Decrease();
			camAnim.SetTrigger("shake");
			Instantiate(effect, transform.position, Quaternion.identity);
			Destroy(gameObject);
		}
	}
}
