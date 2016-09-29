using UnityEngine;
using System.Collections;

public class raptor : MonoBehaviour {
    GameObject[] kuz;
    private int frames;
    //public GameObject zain; //huevos
    //public GameObject tajat; //pedo
    //public GameObject sharmuta;//carne
	// Use this for initialization
	void Start () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        col.GetComponent<AudioSource>().Play();
        if (col.gameObject.tag == "egg")
        {
            //Points._puntos = 1;
            //Destroy(col.gameObject);
        }
        else if (col.gameObject.tag == "carnosa")
        {
            //col.GetComponent<AudioSource>().Play();
            //Points._puntos = 3;
            //Destroy(col.gameObject);
        }
    }

	// Update is called once per frame
	void Update () {

	}
}
