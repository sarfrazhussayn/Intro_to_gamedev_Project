using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	public GameObject[] obstaclePatterns;
	public float timeBtwSpawn;
	public float startTimeBtwSpawn;
	public float decreaseTime=0.1f;
	public float minTime = 1f;
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    void Update()
    {
		if( timeBtwSpawn <= 0){
			int rand = Random.Range(0,obstaclePatterns.Length);
			Instantiate(obstaclePatterns[rand],transform.position, Quaternion.identity);
			timeBtwSpawn = startTimeBtwSpawn;
			if(startTimeBtwSpawn >minTime){
				startTimeBtwSpawn -= decreaseTime;
			}
		}else{
			timeBtwSpawn -= Time.deltaTime;
		}        
    }
}
