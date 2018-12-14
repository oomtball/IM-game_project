using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class deskDoorAButton : MonoBehaviour {
    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    public static Transform player;
    public static bool doorAFinish = false;
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
        float dist = Vector3.Distance(player.position, transform.position);
        if (dist <= 15 && !isTalking)
        {
            doorANum1.red.SetActive(false);
            doorANum1.blue.SetActive(false);
            doorANum1.green.SetActive(false);
            doorANum1.yellow.SetActive(false);
            doorANum2.red.SetActive(false);
            doorANum2.blue.SetActive(false);
            doorANum2.green.SetActive(false);
            doorANum2.yellow.SetActive(false);
            doorANum3.red.SetActive(false);
            doorANum3.blue.SetActive(false);
            doorANum3.green.SetActive(false);
            doorANum3.yellow.SetActive(false);
            doorANum4.red.SetActive(false);
            doorANum4.blue.SetActive(false);
            doorANum4.green.SetActive(false);
            doorANum4.yellow.SetActive(false);
            doorANum1.hasColor = false;
            doorANum2.hasColor = false;
            doorANum3.hasColor = false;
            doorANum4.hasColor = false;
            if (doorANum1.ans1IsRight && doorANum2.ans2IsRight && doorANum3.ans3IsRight && doorANum4.ans4IsRight)
            {
                talkFlowchart.ExecuteBlock("doorARight");
                doorAFinish = true;
            }
            else{
                talkFlowchart.ExecuteBlock("doorAWrong");
            }
        }
    }
}
