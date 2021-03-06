﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class butterflyMachine : MonoBehaviour {

    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    public Flowchart butterflyMachineFlowchart;
    public static Transform player;
    public static bool butterMachineOpen = false;

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

    public static bool isChoosing
    {
        get { return flowchartManager.GetBooleanVariable("choosing"); }
    }

    private void OnMouseDown()
    {
        float dist = Vector3.Distance(player.position, transform.position);
        if (dist <= 30 && !isTalking)
        {
            if (tanglangLocker.tanglangKeyOpen == false)
            {
                talkFlowchart.ExecuteBlock(talkFlowchart.FindBlock("noReaction"));
            }
            else
            {
                butterflyMachineFlowchart.ExecuteBlock("butterflyMachineOpen");
                butterMachineOpen = true;
            }
        }
    }
}
