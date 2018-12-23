using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class girlBTalking : MonoBehaviour {
    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    public Transform player;
    public static bool afterKitchen = false;
    public static bool afterPart2 = false;
    public static bool girlBPart1 = false;
    public static bool girlBPart2 = false;
    public static bool girlBPart3 = false;

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
                if (!girlBPart1)
                {
                    talkFlowchart.ExecuteBlock("girlBPart1");
                    girlBPart1 = true;
                }
            }
            else if (afterKitchen && !afterPart2)
            {
                if (!girlBPart2)
                {
                    talkFlowchart.ExecuteBlock("girlBPart2");
                    girlBPart2 = true;
                }
            }
            else if (afterPart2)
            {
                if (!girlBPart3)
                {
                    talkFlowchart.ExecuteBlock("girlBPart3");
                    girlBPart3 = true;
                }
            }
        }
    }
}
