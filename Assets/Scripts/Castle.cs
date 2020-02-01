using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Castle : MonoBehaviour
{
    public GameObject castle;

    Player_Life PL;

    public Vector3[] stages;

    private void Start()
    {
        PL = FindObjectOfType<Player_Life>();
    }

    // Update is called once per frame
    void Update()
    {
        castle.transform.position = stages[PL.health];
    }
}