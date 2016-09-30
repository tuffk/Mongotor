using UnityEngine;
using System.Collections;

public class doublepenetration : MonoBehaviour {
    
    
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	if(lakague1.alpha && lakague2.beta)
        {
            Destroy(this.gameObject);
        }
	}


    
    }
   
