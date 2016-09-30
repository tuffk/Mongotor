using UnityEngine;
using System.Collections;

public class trigermorado : MonoBehaviour {
    public static bool purpuple;
    public GameObject brrame;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider otro)
    {
        if (otro.gameObject.tag == "morado")
        {
            purpuple = true;
            Destroy(brrame);
        }
    }
    void OnTriggerExit(Collider otro)
    {
        if (otro.gameObject.tag == "morado")
            purpuple = false;
    }
}
