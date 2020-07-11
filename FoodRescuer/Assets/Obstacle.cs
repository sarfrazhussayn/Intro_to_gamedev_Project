using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Obstacle : MonoBehaviour
{	public int	damage = 10; 
	public float speed;
    	public Text ScoreText;
    // // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    void Update()
    {
		transform.Translate(Vector2.down * speed * Time.deltaTime);
    }

	void OnTriggerEnter2D(Collider2D other){
		if (other.CompareTag("Player")){
			other.GetComponent<PlayerCollision>().score -= damage;
			Debug.Log(other.GetComponent<PlayerCollision>().score);
			Destroy(gameObject);
			ScoreText.text = "Score: "+ Mathf.Round(other.GetComponent<PlayerCollision>().score);
		}
	}
}
