﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class purple : MonoBehaviour
{
    public static bool down = false;
    public GameObject item;
    public static Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame

    private void OnMouseDown()
    {
        float dist = Vector3.Distance(player.position, transform.position);
        if (dist <= 30)
        {
            if (!down)
            {
                item.transform.position = new Vector3(90.4f, -5.3f, -1880.7f);
                down = true;
            }
            else
            {
                item.transform.position = new Vector3(90.4f, 1.9f, -1880.7f);
                down = false;
            }
        }
    }
}
