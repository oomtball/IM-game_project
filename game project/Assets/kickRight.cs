using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class kickRight : MonoBehaviour
{
    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    public GameObject red;
    public GameObject white;
    public GameObject orange;
    public GameObject yellow;
    public GameObject green;
    public GameObject black;
    public GameObject purple;
    public GameObject blue;
    // Start is called before the first frame update
    void Start()
    {
        flowchartManager = GameObject.FindGameObjectWithTag("flowchartController").GetComponent<Flowchart>();
        talkFlowchart = GameObject.FindGameObjectWithTag("talkFlowchart").GetComponent<Flowchart>();
    }

    public static bool isTalking
    {
        get { return flowchartManager.GetBooleanVariable("talking"); }
    }
    // Update is called once per frame

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isTalking)
        {
            talkFlowchart.ExecuteBlock("kickRight");
            Destroy(red);
            Destroy(white);
            Destroy(orange);
            Destroy(yellow);
            Destroy(green);
            Destroy(black);
            Destroy(purple); 
            Destroy(blue);
        }
    }
}
