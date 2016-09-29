using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class texteamela : MonoBehaviour
{
    public UnityEngine.UI.Text kuz; //en el canvas
    public TextMesh zain; //leterero
    public static bool win;
    public static bool death;
    public GameObject cliff;
    // Use this for initialization
    public void Start()
    {
        kuz.text = "ir efenen a shirem in di tokhes";
        kuz.raycastTarget = false;
        kuz.enabled = false;
        win = death = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (win)
        {
            kuz.text = "got the AREPA";
            kuz.color = new Color(255f, 255f, 0f);
            kuz.enabled = true;
        }else if (death)
        {
            kuz.text = "RWAAAAAAARRRRR (game over)";
            kuz.color = new Color(255f, 0f, 0f);
            kuz.enabled = true;
        }
        if (cliff == null)
            zain.text = "puedes pasar";

    }
}
