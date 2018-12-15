using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class boyAEndCube : MonoBehaviour {
    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    private bool inWater = false;
    // Use this for initialization
    void Start () {
        flowchartManager = GameObject.FindGameObjectWithTag("flowchartController").GetComponent<Flowchart>();
        talkFlowchart = GameObject.FindGameObjectWithTag("talkFlowchart").GetComponent<Flowchart>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.CompareTag("bottle") && !inWater){
            talkFlowchart.ExecuteBlock("bottleFlow");
            inWater = true;
        }
    }
}
