using UnityEngine;
using System.Collections;

public class pozo : MonoBehaviour
{
    public mover mv;
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
        //print("colisono" + col.gameObject.name );
        if (col.gameObject.name == "Raptor")
        {
            Raptor_Control._cindyMuere = true;
            texteamela.death = true;
            mv.enabled = false;
            StartCoroutine(myMuero(2.5f));
            
        }
    }

    

    IEnumerator myMuero(float delay)
    {
        yield return new WaitForSeconds(delay);
        mv.mekai();
        mv.enabled = true;
        tx.Start();
        Raptor_Control._cindyMuere = false;
    }
}
