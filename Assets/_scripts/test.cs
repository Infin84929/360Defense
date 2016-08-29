using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {
	public float movementScale;
	void Update() {
		Vector3 pos = transform.position;
		pos.y = Vector3.Dot(Input.gyro.gravity, Vector3.up) * movementScale;
		transform.position = pos;
		print (pos);
	}
}