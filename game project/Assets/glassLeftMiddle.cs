using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class glassLeftMiddle : MonoBehaviour
{
    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    public static Transform player;
    private void Awake()
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
        float dist = Vector3.Distance(player.transform.position, transform.position);
        if (tanglangGetting.gettingTanglang && dist <= 30 && !isTalking)
        {
            tanglangGetting.gettingTanglang = false;
            tanglangGetting.canGetThis = false;
            talkFlowchart.ExecuteBlock("tanglangBite");
        }
    }
}
