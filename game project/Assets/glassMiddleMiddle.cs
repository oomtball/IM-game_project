using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class glassMiddleMiddle : MonoBehaviour
{
    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    public static Transform player;
    private void Awake()
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
        float dist = Vector3.Distance(player.transform.position, transform.position);
        if (tanglangGetting.gettingTanglang && dist <= 30 && !isTalking)
        {
            tanglangGetting.gettingTanglang = false;
            tanglangGetting.canGetThis = false;
            tanglangGetting.tanglang.GetComponent<Rigidbody>().useGravity = true;
            tanglangGetting.tanglang.GetComponent<Rigidbody>().isKinematic = false;
            tanglangGetting.tanglang.GetComponent<Rigidbody>().detectCollisions = true;
            tanglangGetting.tanglang.transform.SetParent(null, true);
            talkFlowchart.ExecuteBlock("tanglangBite");
        }
        else if (!tanglangGetting.gettingTanglang && dist <= 30 && !isTalking){
            if (!elecOpen.isLight)
                talkFlowchart.ExecuteBlock("noTouch");
            else
                talkFlowchart.ExecuteBlock("thisIsCicada");
        }
    }
}
