using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed;
	// Use this for initialization
	void Start () {
		speed = 200;
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.RotateAround(Vector3.zero, Vector3.back, Input.acceleration.x * speed * Time.deltaTime);
	}
}
