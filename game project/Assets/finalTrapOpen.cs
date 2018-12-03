using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class finalTrapOpen : MonoBehaviour {
    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    public static Transform player;
    public bool finish = false;

    void Awake()
    {
        flowchartManager = GameObject.FindGameObjectWithTag("flowchartController").GetComponent<Flowchart>();
        talkFlowchart = GameObject.FindGameObjectWithTag("talkFlowchart").GetComponent<Flowchart>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private void Update()
    {
        if (!doorBOne.up && !doorBTwo.up && doorBThree.up && !doorBFour.up && !doorBFive.up && doorBSix.up &&
            doorBSeven.up && !doorBEight.up && !doorBNine.up && doorBZero.up && finish == false){
            talkFlowchart.ExecuteBlock(talkFlowchart.FindBlock("finalTrapOpen"));
            finish = true;
        }
    }
}