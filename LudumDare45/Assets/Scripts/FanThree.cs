using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanThree : MonoBehaviour
{
	private Transform player;

	public float distance;

	public bool isFan;

	public float speed;

	private SpriteRenderer rend;
	public Sprite normal;
	public Sprite excited;

	public GameObject effect;

	private Animator camAnim;

	private GM gm;

	private Animator anim;

	private void Start()
	{
		anim = GetComponent<Animator>();
		gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GM>();
		camAnim = Camera.main.GetComponent<Animator>();
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
		rend = GetComponent<SpriteRenderer>();
	}

	private void Update()
	{

		if (isFan == true)
		{
			anim.SetBool("isRunning", true);
			rend.sprite = excited;
			transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
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
