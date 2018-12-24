using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class girlBOpenDoor1 : MonoBehaviour
{
    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    public static bool door1Open = false;
    // Start is called before the first frame update
    void Start()
    {
        flowchartManager = GameObject.FindGameObjectWithTag("flowchartController").GetComponent<Flowchart>();
        talkFlowchart = GameObject.FindGameObjectWithTag("talkFlowchart").GetComponent<Flowchart>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!red.down && !blue.down && !yellow.down && !black.down && !green.down && !white.down && orange.down && purple.down && !door1Open){
            talkFlowchart.ExecuteBlock("finishRoom1");
            door1Open = true;
        }
    }
}
