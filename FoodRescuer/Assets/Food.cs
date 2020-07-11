using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Food : MonoBehaviour
{	public int	damage = 10; 
	public float speed;
	public Text FoodText;
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
			other.GetComponent<PlayerCollision>().food += damage;
			Debug.Log(other.GetComponent<PlayerCollision>().food);
			Destroy(gameObject);
			FoodText.text = "Food: "+ Mathf.Round(other.GetComponent<PlayerCollision>().food);
		}
	}
}
