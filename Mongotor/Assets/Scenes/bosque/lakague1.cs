using UnityEngine;
using System.Collections;

public class lakague1 : MonoBehaviour {
    public static bool alpha;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider otro)
    {
        if (otro.gameObject.tag == "alpha")
            alpha = true; 
    }
    void OnTriggerExit(Collider otro)
    {
        if (otro.gameObject.tag == "alpha")
            alpha = true;
    }
}
