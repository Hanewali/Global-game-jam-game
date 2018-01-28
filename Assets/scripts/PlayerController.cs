using System;
using System.Runtime.InteropServices;
using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

	public Rigidbody2D Player;
	public int Speed = 5;
	public int JumpPower = 20;
	public bool Ground = true;
	public LayerMask PlatformMask;
<<<<<<< HEAD
	public Animation Anim;
		
=======
	public Animator Animator = null;
	public GameObject Dog;
	public GameObject Dog2;
	public GameObject Dog3;
	public GameObject DarkPortal;
	public GameObject Portal;
	public GameObject coli;
	
	private float distToBeacon;
	public GameObject smallBeacon;
	private float beaconCounter = 0f;

	
>>>>>>> 008d6b2... Level 1: Final, winscene, menuscene, all working!
	private bool _flipSide = false;
	private SpriteRenderer _spriteRenderer;
	                                 

	private float distance = 20f;

	// Use this for initialization
	void Start ()
	{ 
		
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		
		
		RaycastHit2D hit = Physics2D.Raycast(Player.position, Vector2.down, distance, PlatformMask);
		
		Vector2 move = new Vector2(Input.GetAxis("Horizontal"),0f);
		Vector2 jump = new Vector2(0f, Player.velocity.y);
		if (hit.collider == null) hit.distance = 0;
		if (Input.GetButtonDown("Jump") && hit.distance < 0.9f)
		{
			//Debug.Log((Ground));
			jump = Vector2.up * JumpPower;
			//InvokeRepeating("Falsing",0.5f,0.1f);
			//Debug.Log((Ground));

<<<<<<< HEAD
			//Debug.Log(Ground);
=======
		if (Input.GetButtonDown("Fire1") && distToBeacon < 1)
		{
			smallBeacon.active = false;
			beacon.transform.position = smallBeacon.transform.position;
			Dog.active = true;
			Dog2.active = true;
			Dog3.active = true;
			beacon.active = true;
			DarkPortal.active = false;
			Portal.transform.position = DarkPortal.transform.position;
			Portal.active = true;

>>>>>>> 008d6b2... Level 1: Final, winscene, menuscene, all working!
		}
		
		Player.velocity = move * Speed + jump;

		transform.localRotation = move.x < 0 ? Quaternion.Euler(0, 0, 0) : Quaternion.Euler(0, 180, 0);
		

//		_flipSide = (_spriteRenderer.flipX ? (move.x > 0.01f) : (move.x < 0.01f));
//		if (_flipSide)
//		{
//			_spriteRenderer.flipX = !_spriteRenderer.flipX;
//		}

	}

	private void OnCollisionStay2D(Collision2D other)
	{
		Ground = true;
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.CompareTag("Platform"))
		{
			//Debug.Log(Ground);
		}
		else if (other.gameObject.CompareTag("Portal"))
		{
			SceneManager.LoadScene("WinScene");
		}
	}

<<<<<<< HEAD
	void Falsing()
	{
		Ground = false;
		Debug.Log(Ground);
=======
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("TriggerStupid"))
		{
			coli.active = false;
		}
>>>>>>> 008d6b2... Level 1: Final, winscene, menuscene, all working!
	}
}
