using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class doorBZero: MonoBehaviour
{
    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    public static bool up = false;
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

    // Use this for initialization
    private void OnMouseDown()
    {
        float dist = Vector3.Distance(player.position, transform.position);
        if (dist <= 30 && !isTalking)
        {
            if (!up)
            {
                Vector3 itemTrans = transform.position;
                transform.position = new Vector3(itemTrans.x + 5, itemTrans.y, itemTrans.z);
                up = true;
            }
            else
            {
                Vector3 itemTrans = transform.position;
                transform.position = new Vector3(itemTrans.x - 5, itemTrans.y, itemTrans.z);
                up = false;
            }
        }
    }
}

