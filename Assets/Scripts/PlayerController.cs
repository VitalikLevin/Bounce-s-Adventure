using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour 
{
	public float speed;
	public float jumpForce;
	private float moveInput;
	private Rigidbody2D rb;
	//Flipper and jumper
	private bool facingRight = true;
	private bool isGrounded;
	public Transform feetPos;
	public float checkRaduis;
	public LayerMask whatIsGround;
	private Animator anim;
	public VectorValue pos;

	private void Start ()
	{
		transform.position = pos.initialValue;
		anim = GetComponent<Animator> ();
		rb = GetComponent<Rigidbody2D> ();
	}
	private void Update ()
	{
		isGrounded = Physics2D.OverlapCircle (feetPos.position, checkRaduis, whatIsGround);
		if (Input.GetKeyDown (KeyCode.Space) && isGrounded == true) 
		{
			rb.velocity = Vector2.up * jumpForce;
			anim.SetTrigger ("takeOf");
		}
		if (isGrounded == true)
		{
			anim.SetBool ("isJumping", false);
		}
		else
		{
			anim.SetBool ("isJumping", true);
		}
	}
	private void FixedUpdate ()
	{
		moveInput = Input.GetAxis ("Horizontal");
		rb.velocity = new Vector2 (moveInput * speed, rb.velocity.y);
		if (facingRight == false && moveInput > 0) 
		{
			Flip ();
		} 
		else if (facingRight == true && moveInput < 0) 
		{
			Flip ();
		}
		if (moveInput == 0) 
		{
			anim.SetBool ("isRunning", false);
		}
		else
		{
			anim.SetBool ("isRunning", true);
		}
	}

	void Flip ()
	{
		facingRight = !facingRight;
		Vector3 Scaler = transform.localScale;
		Scaler.x *= -1;
		transform.localScale = Scaler;
	}
}
