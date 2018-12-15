using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class NPCTalkable : MonoBehaviour
{
    public Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    public string onMouseDown;
    public Transform player;

    void Awake()
    {
        flowchartManager = GameObject.FindGameObjectWithTag("flowchartController").GetComponent<Flowchart>();
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
            Block targetBlock = talkFlowchart.FindBlock(onMouseDown);
            talkFlowchart.ExecuteBlock(targetBlock);
        }
    }
}
