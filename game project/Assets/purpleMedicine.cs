using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class purpleMedicine : MonoBehaviour {
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
    public static bool redBasin
    {
        get { return talkFlowchart.GetBooleanVariable("redBasin"); }
    }
    public static bool blueBasin
    {
        get { return talkFlowchart.GetBooleanVariable("blueBasin"); }
    }
    public static bool purpleBasin
    {
        get { return talkFlowchart.GetBooleanVariable("purpleBasin"); }
    }

    private void OnMouseDown()
    {
        float dist = Vector3.Distance(player.position, transform.position);
        if (dist <= 30 && purpleBasin)
        {
            talkFlowchart.ExecuteBlock(talkFlowchart.FindBlock("purpleBasinSay"));
        }
    }
}
