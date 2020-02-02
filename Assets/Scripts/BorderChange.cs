using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderChange : MonoBehaviour
{

    SpriteRenderer sr;
    public Sprite[] marcos;

    RandomIndex RI;

    // Start is called before the first frame update
    void Start()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();

        RI = FindObjectOfType<RandomIndex>();
    }

    // Update is called once per frame
    void Update()
    {
        sr.sprite = marcos[RI.categoria];
    }
}
