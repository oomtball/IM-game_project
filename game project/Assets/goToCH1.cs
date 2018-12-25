using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.SceneManagement;

public class goToCH1 : MonoBehaviour
{
    // Start is called before the first frame update
    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    private void Start()
    {
        flowchartManager = GameObject.FindGameObjectWithTag("flowchartController").GetComponent<Flowchart>();
        talkFlowchart = GameObject.FindGameObjectWithTag("talkFlowchart").GetComponent<Flowchart>();
    }
    public static bool go
    {
        get { return talkFlowchart.GetBooleanVariable("go"); }
    }
    // Update is called once per frame
    void Update()
    {
        if (go){
            SceneManager.LoadScene("CH1");
        }
    }
}
