using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trail : MonoBehaviour
{
    private SpriteRenderer rend;
	public Sprite[] sprites;

	public float lifetime;

	private void Start()
	{
		rend = GetComponent<SpriteRenderer>();
		Destroy(gameObject, lifetime);
		int rand = Random.Range(0, sprites.Length);
		rend.sprite = sprites[rand];
	}
}
