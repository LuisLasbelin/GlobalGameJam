using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Castillo : MonoBehaviour
{
    public GameObject castle;

    
    // Start is called before the first frame update
    void Start()
    {
        castle = GameObject.Find("Castle");
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = castle.transform.position + Vector3.forward * 100f;


    }
}
