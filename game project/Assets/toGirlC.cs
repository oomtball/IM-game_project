﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toGirlC : MonoBehaviour
{
    public static Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.position = new Vector3(1152, 31.6f, 0);
        }
    }
}