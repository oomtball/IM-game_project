using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class kitchenCube : MonoBehaviour {

    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    public GameObject cube;
    public static bool end1Start = false;

    void Awake()
    {
        flowchartManager = GameObject.FindGameObjectWithTag("flowchartController").GetComponent<Flowchart>();
        talkFlowchart = GameObject.FindGameObjectWithTag("talkFlowchart").GetComponent<Flowchart>();
        cube.SetActive(false);
    }

    public static bool isTalking
    {
        get { return flowchartManager.GetBooleanVariable("talking"); }
    }

    public static bool isChoosing
    {
        get { return flowchartManager.GetBooleanVariable("choosing"); }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (ch1Plot.talkAfter5Books)
                talkFlowchart.ExecuteBlock("plotKitchen");
            else
            {
                if (!end1Start)
                {
                    talkFlowchart.ExecuteBlock("plotEnd1");
                    end1Start = true;
                }
            }
        }
        Destroy(GameObject.Find("kitchenCube"));
    }
}
