using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;

	private Rigidbody2D rb;
	private Animator anim;

	private Vector2 moveVelocity;

	public SpriteRenderer rend;
	public Sprite good;
	public Sprite bad;

	public GameObject twirl;

	private void Start()
	{
		anim = GetComponent<Animator>();
		rb = GetComponent<Rigidbody2D>();
	}

	private void Update()
	{
		Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
		moveVelocity = moveInput.normalized * speed;

		if(moveInput != Vector2.zero){
			anim.SetBool("isRunning", true);
		} else
		{
			anim.SetBool("isRunning", false);

		}


		if(Input.GetMouseButtonDown(0)){
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
