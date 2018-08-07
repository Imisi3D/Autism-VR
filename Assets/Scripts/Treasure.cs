using UnityEngine;
using System.Collections;

public class Treasure : MonoBehaviour {

	public int value = 10;
	public GameObject explosionPrefab;

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Player") {
			if (GameManager1.gm!=null)
			{
				// tell the game manager to Collect
				GameManager1.gm.Collect (value);
			}
			
			// explode if specified
			if (explosionPrefab != null) {
				Instantiate (explosionPrefab, transform.position, Quaternion.identity);
			}
			
			// destroy after collection
			Destroy (gameObject);
		}
	}
}
