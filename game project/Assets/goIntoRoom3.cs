using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class goIntoRoom3 : MonoBehaviour
{
    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    public GameObject barrier;
    // Start is called before the first frame update
    void Start()
    {
        talkFlowchart = GameObject.FindGameObjectWithTag("talkFlowchart").GetComponent<Flowchart>();
        flowchartManager = GameObject.FindGameObjectWithTag("flowchartController").GetComponent<Flowchart>();
    }

    // Update is called once per frame
  
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")){
            talkFlowchart.ExecuteBlock("goIntoRoom3");
            Destroy(barrier);
        }
    }
}
