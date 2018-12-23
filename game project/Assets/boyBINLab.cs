using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class boyBINLab : MonoBehaviour
{
    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    public static Transform player;
    private int x = 0;
    // Start is called before the first frame update
    void Start()
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
    // Update is called once per frame
   
    private void OnMouseDown()
    {
        float dist = Vector3.Distance(player.position, transform.position);
        if (dist <= 30 && !isTalking && !isChoosing)
        {
            if (x % 3 == 0)
            {
                talkFlowchart.ExecuteBlock("boyBChat1");
                x += 1;
            }
            else if (x % 3 == 1)
            {
                talkFlowchart.ExecuteBlock("boyBChat2");
                x += 1;
            }
            else
            {
                talkFlowchart.ExecuteBlock("boyBChat3");
                x += 1;
            }
            
        }
    }
}
