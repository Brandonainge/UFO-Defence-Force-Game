using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
	public ScoreManager scoreManager; // Store reference to score manager

	public int scoreToGive;

	void start()
	{
		scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); // Find ScoreManager gameobject and reference ScoreManager script component
	}
    void OnTriggerEnter(Collider other)
    {
		SoundManager.PlaySound("mi_explosion_03_hpx");
	    scoreManager.IncreaseScore(scoreToGive); // Increase the score
	    Destroy(gameObject); // destroy this game object
	    Destroy(other.gameObject); // destroys the other game object it hits
    }
}
