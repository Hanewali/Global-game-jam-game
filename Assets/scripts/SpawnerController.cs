using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Comparers;

public class SpawnerController : MonoBehaviour
{
	public GameObject portal;
	public GameObject enemy;
	public GameObject enemy2;
	public GameObject enemy3;
	public GameObject chosenEnemy = null;

	//private float randx;
	public Vector2 whereToSpawn;
	public float spawRate = 1f;
	private float nextSpawn = 0.0f;
	private float dogCounter = 0f;

	private int randomizer;
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		randomizer = (int) Random.Range(1, 4);

		switch (randomizer)
		{
				case 1:
					chosenEnemy = enemy;
					break;
				case 2:
					chosenEnemy = enemy2;
					break;
				case 3:
					chosenEnemy = enemy3;
					break;
				default:
					Debug.Log("Fuck!");
					break;
		}
		
		if (Time.time > nextSpawn && dogCounter < 20 && portal.active == true)
		{
			nextSpawn = Time.time + spawRate;
			//randx = Random.Range(10f, 12f);
			whereToSpawn = new Vector2(portal.transform.position.x - 2, transform.position.y);
			Instantiate(chosenEnemy, whereToSpawn, Quaternion.identity);
			dogCounter++;
		}
	}

}
