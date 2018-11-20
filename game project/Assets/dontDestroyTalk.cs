using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class dontDestroyTalkFlowchart : MonoBehaviour {

    // Use this for initialization
    static Flowchart instanceTalkFlowchart;
    private static bool cloneFlowchart = false;
    private void Awake()
    {
        if (cloneFlowchart == false)
        {
            instanceTalkFlowchart = GameObject.FindGameObjectWithTag("talkFlowchart").GetComponent<Flowchart>();
            DontDestroyOnLoad(this);
            name = "initial talk flowchart";
            cloneFlowchart = true;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
