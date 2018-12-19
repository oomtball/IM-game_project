using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class trap : MonoBehaviour {
    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    int flag = 0;
    private void Awake()
    {
        flowchartManager = GameObject.FindGameObjectWithTag("flowchartController").GetComponent<Flowchart>();
        talkFlowchart = GameObject.FindGameObjectWithTag("talkFlowchart").GetComponent<Flowchart>();
    }
    public static bool back
    {
        get { return talkFlowchart.GetBooleanVariable("back"); }
    }
    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        if (other.CompareTag("Player")){
            other.transform.position = new Vector3(57.32f, 173, -72.76f);
            if (flag == 0)
            {
                talkFlowchart.ExecuteBlock("goBack");
                flag = 1;
            }
            else if (!back)
            {
                flag = 0;
            }
        }
        
    }
}
