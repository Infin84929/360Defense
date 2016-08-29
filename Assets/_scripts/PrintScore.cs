using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PrintScore : MonoBehaviour {
	public Text scorePrint;
	// Use this for initialization
	void Start () {
		scorePrint.text = "Score: " + 0.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		//scorePrint.text = "Score " + score.ToString;
	}
}
