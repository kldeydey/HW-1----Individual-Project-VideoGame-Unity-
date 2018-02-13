using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour {

	public	float		speed;
	public int 			count;
	public	Text		winText;
	public	Text		countText;
	public Scene		scene;

	private	Rigidbody	rb;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
		scene = SceneManager.GetActiveScene ();
		speed = 5f;
		winText.text = "";
		countText.text = "";
		count = 0;
	}

	void FixedUpdate()
	{
		if (Input.GetKey("escape"))
			SceneManager.LoadScene ("Menu");
		
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Coins"))
		{
			other.gameObject.SetActive (false);
			count++;
			countText.text = "Count: " + count.ToString ();
			if (count >= 12)
				winText.text = "WINNER :)";
		}
	}
}
