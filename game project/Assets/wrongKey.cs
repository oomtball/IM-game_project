using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class wrongKey : MonoBehaviour
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
        if (dist <= 30 && !isTalking)
        {
            if (tanglangGetting.gettingTanglang || butterKeyGetting.gettingButterfly || cicadaKeyGetting.gettingCicada 
                || spiderKeyGetting.gettingSpider)
            {
                talkFlowchart.ExecuteBlock("wrongKey");
            }
        }
    }
}
