using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class heart : MonoBehaviour
{
    public static Transform player;
    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    private bool ya = false;
    // Start is called before the first frame update
    void Start()
    {
        flowchartManager = GameObject.FindGameObjectWithTag("flowchartController").GetComponent<Flowchart>();
        talkFlowchart = GameObject.FindGameObjectWithTag("talkFlowchart").GetComponent<Flowchart>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
   
    private void OnMouseDown()
    {
        float dist = Vector3.Distance(player.position, transform.position);
        if (dist <= 30 && !ya){
            talkFlowchart.ExecuteBlock("endLabPlot");
            ya = true;
        }
    }
}
