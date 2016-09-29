using UnityEngine;
using System.Collections;

public class destroyP : MonoBehaviour {

	float lifetime = 3.0f;
	void Awake() {
		Destroy (gameObject, lifetime);
	}

    void OnCollisionEnter(Collision otro)
    {
        if (otro.gameObject.tag == "totem")
            Destroy(otro.transform.parent.gameObject);
        if (otro.transform.tag != "raptor")
            Destroy(this.gameObject);
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
