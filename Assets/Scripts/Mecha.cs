using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mecha : MonoBehaviour
{

    cannon_shoot cs;

    SpriteRenderer sr;

    public Transform chispas;

    // Start is called before the first frame update
    void Start()
    {
        cs = FindObjectOfType<cannon_shoot>();

        sr = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        sr.size = new Vector2(cs.currTime + 1f, 0.8f);

        chispas.position = new Vector3(transform.position.x - cs.currTime, transform.position.y , transform.position.z);
    }
}
