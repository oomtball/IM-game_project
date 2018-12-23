using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class boyATalking : MonoBehaviour {
    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    public Transform player;
    public static bool afterKitchen = false;
    public static bool afterPart2 = false;
    public static bool boyAPart1 = false;
    public static bool boyAPart2 = false;
    public static bool boyAPart3 = false;

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
    private void OnMouseDown()
    {
        float dist = Vector3.Distance(player.position, transform.position);
        if (dist <= 30 && !isTalking && !isChoosing)
        {
            if (!afterKitchen)
            {
                if (!boyAPart1)
                {
                    talkFlowchart.ExecuteBlock("boyAPart1");
                    boyAPart1 = true;
                }
            }
            else if (afterKitchen && !afterPart2)
            {
                if (!boyAPart2)
                {
                    talkFlowchart.ExecuteBlock("boyAPart2");
                    boyAPart2 = true;
                }
            }
            else if (afterPart2)
            {
                if (!boyAPart3)
                {
                    talkFlowchart.ExecuteBlock("boyAPart3");
                    boyAPart3 = true;
                }
            }
        }
    }
}
