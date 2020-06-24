using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour

{
	public bool GamePaused = false;

	public GameObject pauseScreen;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
        	if (GamePaused){
        		ResumeMethod();
        	}
        	else{
        		PauseMethod();
        	}
        }
    }

    public void PauseMethod(){
    	pauseScreen.SetActive(true);
    	Time.timeScale = 0f;
    	GamePaused=true;
    }
    public void ResumeMethod(){
    	pauseScreen.SetActive(false);
    	Time.timeScale = 1f;
    	GamePaused=false;

    }
}
