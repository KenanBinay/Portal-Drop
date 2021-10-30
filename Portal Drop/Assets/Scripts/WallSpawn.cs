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
		
	}

	public void FixedUpdate()
	{
		if (Character.ScoreControl <= 0f)
		{
			if (Time.time > nextSpawn)
			{

				nextSpawn = Time.time + spawnRate;

				randY = Random.Range(-15f, -8.5f);

				ScoreRandY = Random.Range(-3.5f, 3.5f);

				ScoreRandx = Random.Range(4.5f, 5.5f);

				whereToSpawn = new Vector2(transform.position.x, randY);

				whereToSpawnScore = new Vector2(ScoreRandx, ScoreRandY);

                if (Score.scoreValue <= 91)
                {
					spawnRate = 6f;
					ScoreManagment.ScoreSpeed = 0.009f;
					Wall.WallSpeed = 0.009f;
					Instantiate(wall, whereToSpawn, Quaternion.identity);
					if (Score.scoreValue % 5 == 1)
					{
						Instantiate(ScoreObject, whereToSpawnScore, Quaternion.identity);
					}
				}

				if (Score.scoreValue >= 91&&Score.scoreValue <= 121)
				{
					spawnRate = 4f;
					ScoreManagment.ScoreSpeed = 0.015f;
					Wall.WallSpeed = 0.015f;
					Instantiate(wall, whereToSpawn, Quaternion.identity);
                    if (Score.scoreValue % 2 == 1)
                    {
						Instantiate(ScoreObject, whereToSpawnScore, Quaternion.identity);
					}				
				}

				if (Score.scoreValue >=121 && Score.scoreValue <= 699)
				{
					spawnRate = 3f;
					ScoreManagment.ScoreSpeed = 0.020f;
					Wall.WallSpeed = 0.020f;
					Instantiate(wall, whereToSpawn, Quaternion.identity);
					if (Score.scoreValue % 2 == 1)
					{
						Instantiate(ScoreObject, whereToSpawnScore, Quaternion.identity);
					}
				}

				if (Score.scoreValue >= 700)
				{
					spawnRate = 3f;
					ScoreManagment.ScoreSpeed = 0.030f;
					Wall.WallSpeed = 0.030f;
					Instantiate(wall, whereToSpawn, Quaternion.identity);
					if (Score.scoreValue % 50 == 1)
					{
						Instantiate(ScoreObject, whereToSpawnScore, Quaternion.identity);
					}
				}
			}
		}
	}	
}
