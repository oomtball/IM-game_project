using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class beetleKey : MonoBehaviour {
    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    public string onMouseDown;
    public static Transform player;


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
    public static int beetleTimes
    {
        get { return talkFlowchart.GetIntegerVariable("beetleKeyTimes"); }
    }
    private void OnMouseDown()
    {
        float dist = Vector3.Distance(player.position, transform.position);
        if (dist <= 15 && !isTalking && beetleTimes == 0)
        {
            Block targetBlock = talkFlowchart.FindBlock(onMouseDown);
            talkFlowchart.ExecuteBlock(targetBlock);
        }
    }
}
