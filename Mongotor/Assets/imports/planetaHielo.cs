using UnityEngine;
using System.Collections;

public class planetaHielo : MonoBehaviour {

    public Material hielo;
    public GameObject efecto;
    void OnCollisionEnter(Collision otro)
    {
        if (otro.gameObject.tag == "planeta")
        {
            gameObject.GetComponent<Renderer>().sharedMaterial = hielo;
            Instantiate(efecto, transform.position + transform.up * 11.5f, Quaternion.identity);
            Destroy(otro.gameObject);
            Destroy(GameObject.Find("Meteor Storm"));
        }
            

    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
