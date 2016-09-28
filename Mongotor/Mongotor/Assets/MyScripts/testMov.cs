using UnityEngine;
using System.Collections;

public class testMov : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, 3));
        }else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 3, 0);
        }else if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -3, 0);
        }
	
	}
}
