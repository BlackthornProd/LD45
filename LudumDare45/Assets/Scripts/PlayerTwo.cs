using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwo : MonoBehaviour
{
	public float speed;

	private Animator anim;
	private Rigidbody2D rb;

	public SpriteRenderer rend;
	public Sprite good;
	public Sprite bad;

	public GameObject twirl;

	private Vector2 moveVelocity;

	private void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
	}

	private void Update()
	{
		Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), 0);
		moveVelocity = moveInput.normalized * speed;

		if (moveInput != Vector2.zero)
		{
			anim.SetBool("isRunning", true);
		}
		else
		{
			anim.SetBool("isRunning", false);

		}


		if (Input.GetMouseButtonDown(0))
		{
			rend.sprite = bad;
			twirl.SetActive(true);
		}

		if (Input.GetMouseButtonUp(0))
		{
			rend.sprite = good;
			twirl.SetActive(false);
		}
	}

	private void FixedUpdate()
	{
		rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
	}
}
