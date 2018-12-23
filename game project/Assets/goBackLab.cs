using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.SceneManagement;

public class goBackLab : MonoBehaviour
{
    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    // Start is called before the first frame update
    void Start()
    {
        flowchartManager = GameObject.FindGameObjectWithTag("flowchartController").GetComponent<Flowchart>();
        talkFlowchart = GameObject.FindGameObjectWithTag("talkFlowchart").GetComponent<Flowchart>();
    }
    public static bool backToLab
    {
        get { return talkFlowchart.GetBooleanVariable("backToLab"); }
    }
    // Update is called once per frame
    void Update()
    {
        if (backToLab)
        {
            SceneManager.LoadScene("boyB");
        }
    }
}
