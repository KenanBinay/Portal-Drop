using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawn : MonoBehaviour
{
	public GameObject wall;
	public GameObject ScoreObject;

	float randY;
	float ScoreRandY;
	float ScoreRandx;
	Vector2 whereToSpawn;
	Vector2 whereToSpawnScore;
	public float spawnRate;
	public static float nextSpawn = 0.0f;
	
	void Start()
	{
		spawnRate = 6f;
	}

	public void FixedUpdate()
	{
		if (Character.ScoreControl <= 0f)
		{
			if (Time.time > nextSpawn)
			{

				nextSpawn = Time.time + spawnRate;

				randY = Random.Range(-15f, -8.5f);

				ScoreRandY = Random.Range(-3.5f, 3.3f);

				ScoreRandx = Random.Range(5f, 6.2f);

				whereToSpawn = new Vector2(transform.position.x, randY);

				whereToSpawnScore = new Vector2(ScoreRandx, ScoreRandY);

                if (Score.scoreValue <= 30)
                {
					ScoreManagment.ScoreSpeed = 0.009f;
					Instantiate(wall, whereToSpawn, Quaternion.identity);
					if (Score.scoreValue % 5 == 1)
					{
						Instantiate(ScoreObject, whereToSpawnScore, Quaternion.identity);
					}
				}
				if (Score.scoreValue >= 31 && Score.scoreValue <= 60)
				{
					Wall.WallSpeed = 0.018f;
					ScoreManagment.ScoreSpeed = 0.018f;
					spawnRate = 5f;
					Instantiate(wall, whereToSpawn, Quaternion.identity);
                    if (Score.scoreValue % 2 == 1)
                    {
						Instantiate(ScoreObject, whereToSpawnScore, Quaternion.identity);
					}				
				}
				if (Score.scoreValue >= 61 && Score.scoreValue >= 90)
				{
					Wall.WallSpeed = 0.027f;
					ScoreManagment.ScoreSpeed = 0.027f;
					spawnRate = 4f;
					Instantiate(wall, whereToSpawn, Quaternion.identity);
					if (Score.scoreValue % 2 == 1)
					{
						Instantiate(ScoreObject, whereToSpawnScore, Quaternion.identity);
					}
				}
				
				
			}

		}
	}
	
}
