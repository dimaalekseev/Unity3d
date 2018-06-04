using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerScript : MonoBehaviour {
	public float jumpForce;
	public Rigidbody2D rb;
	public int combo =1;
	public int score = 0;
	public Text uiScore;
	public float forwardSpeed;
	public GameObject text; 
	bool didFlap = false;

	public bool gameOver = false;

	void Start () {
		
	}
	
	void Update () {
		uiScore.text = score.ToString();
		if (!gameOver) {
			if (Input.GetMouseButtonDown (0))
				didFlap = true;
		}

		if (!gameOver) 
		{
			text.SetActive (false);			
		}

		if (gameOver == true) 
		{
			text.SetActive (true);
		}
	}

	void FixedUpdate()
	{
		rb.AddForce (Vector2.right * forwardSpeed);

		if (didFlap) {
			rb.velocity = new Vector2 (rb.velocity.x, Vector2.up.y * jumpForce);
			didFlap = false;
		}
	}
}
