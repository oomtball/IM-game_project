using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class startPaper : MonoBehaviour {
    public Transform player;
    public GameObject paper;
    public GameObject paper2;
    public GameObject paper1;
    public GameObject paper3;
    public GameObject paper4;
    public GameObject paper5;
    public GameObject paper6;
    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    public static bool pickUpStartPaper = false;
    // Use this for initialization
    void Start () {
        flowchartManager = GameObject.FindGameObjectWithTag("flowchartController").GetComponent<Flowchart>();
        talkFlowchart = GameObject.FindGameObjectWithTag("talkFlowchart").GetComponent<Flowchart>();
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
            pickUpStartPaper = true;
            paper1.SetActive(true);
            paper2.SetActive(true);
            paper3.SetActive(true);
            paper4.SetActive(true);
            paper5.SetActive(true);
            paper6.SetActive(true);
            talkFlowchart.ExecuteBlock("startPaper");
        }
    }
}
