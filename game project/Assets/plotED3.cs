using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;

public class plotED3 : MonoBehaviour
{
    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    // Start is called before the first frame update
    private void Awake()
    {
        flowchartManager = GameObject.FindGameObjectWithTag("flowchartController").GetComponent<Flowchart>();
        talkFlowchart = GameObject.FindGameObjectWithTag("talkFlowchart").GetComponent<Flowchart>();
    }
    public static bool endED3
    {
        get { return talkFlowchart.GetBooleanVariable("goToED3"); }
    }
    // Update is called once per frame
    void Update()
    {
        if (endED3){
            SceneManager.LoadScene("ED3Dark");
        }
    }
}
