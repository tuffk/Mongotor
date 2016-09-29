using UnityEngine;
using System.Collections;

public class arepaWin : MonoBehaviour
{
    public texteamela tx;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Raptor")
        {
            
            texteamela.win = true;
            
        }
    }
}