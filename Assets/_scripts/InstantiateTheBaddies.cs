using UnityEngine;
using System.Collections;


public class InstantiateTheBaddies : MonoBehaviour {

	public GameObject prefab;
	public float gridX = 5f;
	public float gridY = 5f;
	public float spacing = 2f;

	void Start() {
		spawnEnem ();
	}

	void spawnEnem() {
		print (transform.position);
		Instantiate(prefab, transform.position, new Quaternion (transform.rotation.x, transform.rotation.y, transform.rotation.z, transform.rotation.w));
	} 
}