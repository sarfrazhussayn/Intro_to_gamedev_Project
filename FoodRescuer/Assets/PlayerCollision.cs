using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    // Start is called before the first frame update

	public Text scoreText;
	public int score = 0;
    void OnCollisionEnter2D(Collision2D collisionInfo){
    	// Debug.Log("HIT!");
    	if(collisionInfo.collider.tag == "Taxi")
    	{
    		Debug.Log("Hit a Taxi!");
    		Debug.Log("Score -1");
    		Destroy(collisionInfo.gameObject);
    		score = score - 10;
    		if(score<0)
    		{
    			score = 0;
    		}
    		scoreText.text = "Score: " + Mathf.Round(score);
    		
    	}
	   	if(collisionInfo.collider.tag == "Food")
    	{
    		Debug.Log("Food Collected");
    		Debug.Log("Score +1");
    		Destroy(collisionInfo.gameObject);
    		score = score + 10;
    		scoreText.text = "Score: " + Mathf.Round(score);
    	}
    }
}
