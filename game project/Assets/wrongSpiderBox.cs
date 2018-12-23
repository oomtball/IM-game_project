using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class wrongSpiderBox : MonoBehaviour
{
    public Flowchart spiderFlowchart;
    public static Flowchart talkFlowchart;
    public static Transform player;
    void Awake()
    {
        talkFlowchart = GameObject.FindGameObjectWithTag("talkFlowchart").GetComponent<Flowchart>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    private void OnMouseDown()
    {
        float dist = Vector3.Distance(player.position, transform.position);
        if (dist <= 30)
        {
            spiderFlowchart.ExecuteBlock("spiderHead");
            talkFlowchart.ExecuteBlock("wrongSpiderBox");
        }
    }
}
