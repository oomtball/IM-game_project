using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class girlCTalking : MonoBehaviour {
 public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    public Transform player;
    public static bool afterKitchen = false;
    public static bool afterPart2 = false;
    public static bool girlCPart1 = false;
    public static bool girlCPart2 = false;
    public static bool girlCPart3 = false;

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
                if (!girlCPart1)
                {
                    talkFlowchart.ExecuteBlock("girlCPart1");
                    girlCPart1 = true;
                }
            }
            else if (afterKitchen && !afterPart2)
            {
                if (!girlCPart2)
                {
                    talkFlowchart.ExecuteBlock("girlCPart2");
                    girlCPart2 = true;
                }
            }
            else if (afterPart2)
            {
                if (!girlCPart3)
                {
                    talkFlowchart.ExecuteBlock("girlCPart3");
                    girlCPart3 = true;
                }
            }
        }	
	}
}
