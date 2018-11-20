using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class test1 : MonoBehaviour {

    // Use this for initialization
    static GameObject instanceTalkFlowchart;
    private static bool cloneFlowchart = false;
    private void Awake()
    {
        if (cloneFlowchart == false)
        {
            instanceTalkFlowchart = GameObject.FindGameObjectWithTag("talk").GetComponent<GameObject>();
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
