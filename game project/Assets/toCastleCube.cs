﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
public class toCastleCube : MonoBehaviour
{

    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    public string select;

    void Awake()
    {
        flowchartManager = GameObject.FindGameObjectWithTag("flowchartController").GetComponent<Flowchart>();
        talkFlowchart = GameObject.FindGameObjectWithTag("talkFlowchart").GetComponent<Flowchart>();
    }

    public static bool isTalking
    {
        get { return flowchartManager.GetBooleanVariable("talking"); }
    }

    public static bool isChoosing
    {
        get { return flowchartManager.GetBooleanVariable("choosing"); }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            talkFlowchart.ExecuteBlock("stepInTheRoom");
        }
        Destroy(GameObject.Find("toCastleCube"));
    }
}