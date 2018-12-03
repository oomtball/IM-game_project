﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class threeButton : MonoBehaviour {
    public static bool finalSuccess = false;
    public static int count = 0;
    public static bool right = true;
    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    public static Transform player;
    // Use this for initialization

    void Awake()
    {
        flowchartManager = GameObject.FindGameObjectWithTag("flowchartController").GetComponent<Flowchart>();
        talkFlowchart = GameObject.FindGameObjectWithTag("talkFlowchart").GetComponent<Flowchart>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    public static bool isTalking
    {
        get { return flowchartManager.GetBooleanVariable("talking"); }
    }
    private void OnMouseDown()
    {
        float dist = Vector3.Distance(player.position, transform.position);
        if (dist <= 30 && !isTalking)
        {
            if (sixButton.count == 2 && sevenButton.count == 1 && zeroButton.count == 2 && count == 0)
            {
                count += 1;
                finalSuccess = true;
                talkFlowchart.ExecuteBlock("finalTrapSuccess");
            }
            else
            {
                right = false;
                talkFlowchart.ExecuteBlock("finalTrapFail");
            }
        }
    }
    public static void countZero()
    {
        right = true;
        count = 0;
    }
}
