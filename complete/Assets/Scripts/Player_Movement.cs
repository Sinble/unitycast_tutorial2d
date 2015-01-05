using UnityEngine;
using System.Collections;

public class Player_Movement : MonoBehaviour {

	public float stepSpeed    	= 0.5f;
	public float jumpForce 		= 0.5f;
	public float maxStepSpeed 	= 0.5f;

	private bool isJumping = false;
	// Use this for initialization
	void Start () {
	
	}

	void FixedUpdate() {
				if (Input.GetKey (KeyCode.Space)) {
						if (!isJumping) {
								isJumping = true;
								rigidbody2D.AddForce (transform.up * jumpForce, ForceMode2D.Force);
						}
				}
		
				if (Input.GetKey (KeyCode.D)) {
						if (rigidbody2D.velocity.x < maxStepSpeed) {
								rigidbody2D.AddForce (transform.right * stepSpeed, ForceMode2D.Force);
						}
			
				}
		
				if (Input.GetKey (KeyCode.A)) {
						if (rigidbody2D.velocity.x > -maxStepSpeed) {
								rigidbody2D.AddForce (transform.right * -stepSpeed, ForceMode2D.Force);
						}
			
				}
		}
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D(Collision2D  collision) 
	{
		Collider2D collider = collision.collider;

		Vector3 contactPoint = collision.contacts[0].point;
		Vector3 center = collider.bounds.center;

		if (contactPoint.y > center.y) {
			isJumping = false;
		}

	}
}
