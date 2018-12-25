using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class kickWrong : MonoBehaviour
{
    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    // Start is called before the first frame update
    void Start()
    {
        flowchartManager = GameObject.FindGameObjectWithTag("flowchartController").GetComponent<Flowchart>();
        talkFlowchart = GameObject.FindGameObjectWithTag("talkFlowchart").GetComponent<Flowchart>();
    }

    // Update is called once per frame

    public static bool isTalking
    {
        get { return flowchartManager.GetBooleanVariable("talking"); }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isTalking){
            talkFlowchart.ExecuteBlock("kickWrong");
        }
    }
}
