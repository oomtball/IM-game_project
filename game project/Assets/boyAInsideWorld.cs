using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class boyAInsideWorld : MonoBehaviour
{
    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    public Transform player;

    void Awake()
    {
        talkFlowchart = GameObject.FindGameObjectWithTag("talkFlowchart").GetComponent<Flowchart>();
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
    public static bool throwBottle
    {
        get { return talkFlowchart.GetBooleanVariable("throwBottle"); }
    }
    private void OnMouseDown()
    {
        float dist = Vector3.Distance(player.position, transform.position);
        if (dist <= 30 && !isTalking && !isChoosing)
        {
            if (!throwBottle)
            {
                talkFlowchart.ExecuteBlock("boyAChat");
            }
            else
                talkFlowchart.ExecuteBlock("boyAEndChat");
        }
    }
}
