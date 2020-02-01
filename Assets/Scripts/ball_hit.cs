using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_hit : MonoBehaviour
{

    Player_Life PL;

    // Start is called before the first frame update
    void Start()
    {
        PL = FindObjectOfType<Player_Life>();
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Castle")
        {
            Debug.Log("Castle hit");

            PL.RespuestaMal();

        }

        Destroy(gameObject);

    } // ()
    
}
