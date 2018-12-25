using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class girlBOpenDoor1 : MonoBehaviour
{
    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    public static bool door1Open = false;
    private static bool afterRedFlower = false;
    // Start is called before the first frame update
    void Start()
    {
        flowchartManager = GameObject.FindGameObjectWithTag("flowchartController").GetComponent<Flowchart>();
        talkFlowchart = GameObject.FindGameObjectWithTag("talkFlowchart").GetComponent<Flowchart>();
    }

    public static bool redFlower1
    {
        get { return talkFlowchart.GetBooleanVariable("redFlower1"); }
    }
    public static bool redFlower2
    {
        get { return talkFlowchart.GetBooleanVariable("redFlower2"); }
    }
    public static bool redFlower3
    {
        get { return talkFlowchart.GetBooleanVariable("redFlower3"); }
    }
    public static bool redFlower4
    {
        get { return talkFlowchart.GetBooleanVariable("redFlower4"); }
    }
    public static bool redFlower5
    {
        get { return talkFlowchart.GetBooleanVariable("redFlower5"); }
    }
    public static bool redFlower6
    {
        get { return talkFlowchart.GetBooleanVariable("redFlower6"); }
    }
    public static bool redFlower7
    {
        get { return talkFlowchart.GetBooleanVariable("redFlower7"); }
    }
    public static bool trueRedFlower
    {
        get { return talkFlowchart.GetBooleanVariable("trueRedFlower"); }
    }
    // Update is called once per frame
    void Update()
    {
        if (!red.down && !blue.down && !yellow.down && !black.down && !green.down && !white.down && orange.down && purple.down && !door1Open){
            talkFlowchart.ExecuteBlock("finishRoom1");
            door1Open = true;
        }
        if (redFlower1 && redFlower2 && redFlower3 && redFlower4 && redFlower5 && redFlower6 && redFlower7 && trueRedFlower && !afterRedFlower){
            talkFlowchart.ExecuteBlock("talkAfterRed");
            afterRedFlower = true;
        }
    }
}
