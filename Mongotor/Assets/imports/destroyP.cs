using UnityEngine;
using System.Collections;

public class destroyP : MonoBehaviour {

	float lifetime = 3.0f;
	void Awake() {
		Destroy (gameObject, lifetime);
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
