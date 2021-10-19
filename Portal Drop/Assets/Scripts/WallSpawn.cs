using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawn : MonoBehaviour
{
	public GameObject wall;
	float randY;
	Vector2 whereToSpawn;
	public float spawnRate;
	float nextSpawn = 0.0f;
	
	void Start()
	{
		
	}

	public void FixedUpdate()
	{
		if (Time.time > nextSpawn)
		{

			nextSpawn = Time.time + spawnRate;

			randY = Random.Range(-9f,-4f);

			whereToSpawn = new Vector2(transform.position.x, randY);

			Instantiate(wall, whereToSpawn, Quaternion.identity);
		}
		
	}
}
