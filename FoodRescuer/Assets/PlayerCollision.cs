using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    // Start is called before the first frame update

	public Text scoreText;
	public Text FoodText;

	public GameObject WinScreen;
	public GameObject GameOverScreen;

	public int score = 0;
	public int food = 0;
	void Update()
	{
		if(score == 30)
		{
			WinScreen.SetActive(true);
			Time.timeScale = 0f;
		}
	}
    void OnCollisionEnter2D(Collision2D collisionInfo){
    	// Debug.Log("HIT!");
    	if(collisionInfo.collider.tag == "Taxi")
    	{
    		Debug.Log("Hit a Taxi!");
    		Debug.Log("Score -1");
    		Destroy(collisionInfo.gameObject);
    		score = score - 10;
    		if(score<=0)
    		{
    			score = 0;
    			GameOverScreen.SetActive(true);
    			Time.timeScale=0f;
    		}
    		scoreText.text = "Score: " + Mathf.Round(score);
    		
    	}
	   	if(collisionInfo.collider.tag == "Food")
    	{
    		Debug.Log("Food Collected");
    		Debug.Log("Food +1");
    		Destroy(collisionInfo.gameObject);
    		food = food + 1;
    		FoodText.text = "Food: " + Mathf.Round(food);
    	}
    	if(collisionInfo.collider.tag == "Person")
    	{
    		Debug.Log("Food Delivered");
    		Debug.Log("Score +1");
    		Destroy(collisionInfo.gameObject);
    		score = score + 10;
    		food = food - 1;
    		if(score<0)
    		{
    			score = 0;
    		}
    		scoreText.text = "Score: " + Mathf.Round(score);
    		FoodText.text = "Food: " + Mathf.Round(food);
    		
    	}
    }
}
