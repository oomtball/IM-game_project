using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class girlATalking : MonoBehaviour {
 public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    public Transform player;
    public static bool afterKitchen = false;
    public static bool afterPart2 = false;
    public static bool girlAPart1 = true;

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
                talkFlowchart.ExecuteBlock("girlAPart1");
                girlAPart1 = true;
            }
            else
                talkFlowchart.ExecuteBlock("girlAPart2");

        }
    }
}
