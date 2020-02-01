using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Castle : MonoBehaviour
{
    public GameObject castle;

    // Update is called once per frame
    void Update()
    {

        transform.position = castle.transform.position + Vector3.forward * 100f;


    }
}