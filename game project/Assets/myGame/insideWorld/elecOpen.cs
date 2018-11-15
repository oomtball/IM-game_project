using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class elecOpen : MonoBehaviour
{

    public Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    public string onMouseDown;
    public Transform player;
    public GameObject labLight;

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
        if (dist <= 15 && !isTalking)
        {
            labLight.SetActive(true); // false to hide, true to show
            Block targetBlock = talkFlowchart.FindBlock(onMouseDown);
            talkFlowchart.ExecuteBlock(targetBlock);
        }
    }
}
