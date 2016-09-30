using UnityEngine;
using System.Collections;

public class lakague2 : MonoBehaviour {
    public static bool beta;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider otro)
    {
        if (otro.gameObject.tag == "beta")
            beta = true;
    }
    void OnTriggerExit(Collider otro)
    {
        if (otro.gameObject.tag == "beta")
            beta = true;
    }
}
