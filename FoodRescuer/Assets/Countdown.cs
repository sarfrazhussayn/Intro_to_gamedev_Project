using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{
	public Text text;
	public float timeLeft = 25f;
	public GameObject GameOverScreen;
	public bool GameOver;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	timeLeft -= Time.deltaTime;
    	if(timeLeft<=0){
    		timeLeft=0;
    		GameOver=true;
    		GameOverMethod();
    	}
    	// Debug.Log(timeLeft);
    	text.text = "Time: "+ Mathf.Round(timeLeft);

    }
    public void GameOverMethod(){
    	GameOverScreen.SetActive(true);
    	Time.timeScale = 0f;
    	GameOver=true;
    }

}
