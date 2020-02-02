using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Castle : MonoBehaviour
{
    public GameObject castle, life;

    Player_Life PL;

    public Vector3[] castleStages, lifeStages;

    private void Start()
    {
        PL = FindObjectOfType<Player_Life>();
    }

    // Update is called once per frame
    void Update()
    {
        castle.transform.position = castleStages[PL.health];
        life.transform.position = lifeStages[PL.health];
    }
}