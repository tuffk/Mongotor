using UnityEngine;
using System.Collections;

public class teleport : MonoBehaviour {

    void OnCollisionEnter (Collision other) {

        if (other.gameObject.name == "Teleport1")
        transform.position = new Vector3(591.3f, -19, 1285.4f);
    
        else if (other.gameObject.name == "Teleport2")
        transform.position = new Vector3(-206, -19, 22f);

}

}
