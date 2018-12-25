using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class nineButton : MonoBehaviour
{
    public static bool finalSuccess = false;
    public static int count = 0;
    public static bool right = true;
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
    public static bool isTalking
    {
        get { return flowchartManager.GetBooleanVariable("talking"); }
    }
    private void OnMouseDown()
    {
        talkFlowchart.ExecuteBlock("clickButton");
        if (cicadaLocker.cicadaOpen)
        {
            float dist = Vector3.Distance(player.position, transform.position);
            if (dist <= 30 && !isTalking)
            {
                if (zeroButton.count == 2 && sevenButton.count == 1 && threeButton.count == 1 && count == 1)
                {
                    count += 1;
                    finalSuccess = true;
                    talkFlowchart.ExecuteBlock("finalTrapSuccess");
                }
                else if (zeroButton.count == 0 && sevenButton.count == 1 && threeButton.count == 1 && count == 0)
                {
                    count += 1;
                }
                else
                {
                    right = false;
                    talkFlowchart.ExecuteBlock("finalTrapFail");
                }
            }
        }
        else
        {
            talkFlowchart.ExecuteBlock("noReaction");
        }
    }
    public static void countZero()
    {
        right = true;
        count = 0;
    }
}
