using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class paper5 : MonoBehaviour {
    public Transform player;
    public GameObject paper;
    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    public static bool pickUpPaper5 = false;
    // Use this for initialization
    void Start()
    {
        flowchartManager = GameObject.FindGameObjectWithTag("flowchartController").GetComponent<Flowchart>();
        talkFlowchart = GameObject.FindGameObjectWithTag("talkFlowchart").GetComponent<Flowchart>();
        paper.SetActive(false);
    }

    // Update is called once per frame

    public static bool isTalking
    {
        get { return flowchartManager.GetBooleanVariable("talking"); }
    }

    private void OnMouseDown()
    {
        float dist = Vector3.Distance(player.position, transform.position);
        if (dist <= 30 && !isTalking)
        {
            Destroy(paper);
            pickUpPaper5 = true;
            talkFlowchart.ExecuteBlock("paper5");
        }
    }
}
