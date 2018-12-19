using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class goldenButterfly : MonoBehaviour {
    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    public Flowchart butterflyChart;
    public static Transform player;
    public static bool butterflyInSpecimen = false;
    public static bool butterflyOnSpecimen = false;

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

    public static bool purpleBasin
    {
        get { return talkFlowchart.GetBooleanVariable("purpleBasin"); }
    }

    private void OnMouseDown()
    {
        float dist = Vector3.Distance(player.position, transform.position);
        if (dist <= 30 && !isTalking)
        {
            if (!butterflyMachine.butterMachineOpen)
            {
                talkFlowchart.ExecuteBlock(talkFlowchart.FindBlock("noReaction"));
            }
            else
            {
                if (!butterflyOnSpecimen)
                {
                    butterflyChart.ExecuteBlock("goldenButterfly");
                    butterflyOnSpecimen = true;
                }
                else{
                    if (!purpleBasin)
                    {
                        butterflyChart.ExecuteBlock("goldenButterfly2");
                    }
                    else{
                        butterflyChart.ExecuteBlock("makeButterSpecimen");
                        butterflyInSpecimen = true;
                    }
                }
            }
        }
    }
}
