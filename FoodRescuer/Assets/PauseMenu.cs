// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class PauseMenu : MonoBehaviour

// {
// 	public bool GamePaused = false;

// 	public GameObject pauseScreen;

//     // Update is called once per frame
//     void Update()
//     {
//         if(Input.GetKeyDown(KeyCode.Escape)){
//         	if (GamePaused){
//         		Resume();
//         	}
//         	if(!GamePaused){
//         		Pause();
//         	}
//         }
//     }

//     void Pause(){
//     	pauseScreen.SetActive(true);
//     	Time.timeScale = 0f;
//     	GamePaused=true;
//     }
//     void Resume(){
//     	pauseScreen.SetActive(false);
//     	Time.timeScale = 1f;
//     	GamePaused=false;

//     }
// }
