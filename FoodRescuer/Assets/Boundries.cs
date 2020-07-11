using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundries : MonoBehaviour
{	
	// private Vector2 screenBounds;


    // Start is called before the first frame update
    // void Start()
    // {
    // 	screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,Screen.height,Camera.main.transform.position.z));    
    // }

    // Update is called once per frame
    void Update()
    {
      //   Vector3 viewPos = transform.position;
      //   viewPos.x = Mathf.Clamp(viewPos.x,screenBounds.x,screenBounds.x*-1);
     	// viewPos.y = Mathf.Clamp(viewPos.y,screenBounds.y,screenBounds.y*-1);
      //   transform.position = viewPos;   
    	transform.position = new Vector3(Mathf.Clamp(transform.position.x,471.1f,476.62f),Mathf.Clamp(transform.position.y,164.96f,531f),transform.position.z);
    }
}
