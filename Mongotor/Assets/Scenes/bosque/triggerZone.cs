using UnityEngine;
using System.Collections;


public class triggerZone : MonoBehaviour {
    public static bool EnteredTrigger;

    // Use this for initialization
    void Start () {
        EnteredTrigger = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider otro)
    {
        if(otro.gameObject.tag == "key")
            EnteredTrigger = true;
    }
    void OnTriggerExit(Collider otro)
    {
        if(otro.gameObject.tag=="key")
            EnteredTrigger = false;
    }
}
