using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class doorAController : MonoBehaviour
{
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

    public static bool butterKeyOpen
    {
        get { return talkFlowchart.GetBooleanVariable("butterKeyOpen"); }
    }

    private void OnMouseDown()
    {
        float dist = Vector3.Distance(player.position, transform.position);
        if (dist <= 15 && !isTalking)
        {
            if (!butterKeyOpen)
            {
                talkFlowchart.ExecuteBlock(talkFlowchart.FindBlock("noReaction"));
            }
            else
            {
                Block targetBlock = talkFlowchart.FindBlock(onMouseDown);
                talkFlowchart.ExecuteBlock(targetBlock);
                doorANum1.red.SetActive(false);
                doorANum1.blue.SetActive(false);
                doorANum1.green.SetActive(false);
                doorANum1.yellow.SetActive(false);
                doorANum2.red.SetActive(false);
                doorANum2.blue.SetActive(false);
                doorANum2.green.SetActive(false);
                doorANum2.yellow.SetActive(false);
                doorANum3.red.SetActive(false);
                doorANum3.blue.SetActive(false);
                doorANum3.green.SetActive(false);
                doorANum3.yellow.SetActive(false);
                doorANum4.red.SetActive(false);
                doorANum4.blue.SetActive(false);
                doorANum4.green.SetActive(false);
                doorANum4.yellow.SetActive(false);
            }
        }
    }
}
