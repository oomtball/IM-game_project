using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class elecOpen : MonoBehaviour
{

    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    public string onMouseDown;
    public static Transform player;
    public GameObject labLight;
    public static bool isLight = false;

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
    public static bool canOpenPower
    {
        get { return talkFlowchart.GetBooleanVariable("canOpenLabPower"); }
    }

    private void OnMouseDown()
    {
        float dist = Vector3.Distance(player.position, transform.position);
        if (dist <= 15 && !isTalking)
        {
            if (canOpenPower)
            {
                labLight.SetActive(true); // false to hide, true to show
                Block targetBlock = talkFlowchart.FindBlock(onMouseDown);
                talkFlowchart.ExecuteBlock(targetBlock);
                isLight = true;
            }
            else{
                Block targetBlock = talkFlowchart.FindBlock("noReaction");
                talkFlowchart.ExecuteBlock(targetBlock);
            }
        }
    }
}
