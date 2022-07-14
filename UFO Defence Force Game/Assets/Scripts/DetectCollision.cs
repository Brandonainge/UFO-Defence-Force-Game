using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
  void OnTriggerEnter(Collider other)
  {
	  Destroy(gameObject); // destroy this game object
	  Destroy(other.gameObject); // destroys the other game object it hits
  }
}
