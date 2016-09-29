using UnityEngine;
using System.Collections;

public class quitaPiedra : MonoBehaviour {
    public GameObject standard;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (standard == null && triggerZone.EnteredTrigger)
            Destroy(this.gameObject);
	}
}
