using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;

public class candyToCastle : MonoBehaviour
{
    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    // Start is called before the first frame update
    void Start()
    {
        flowchartManager = GameObject.FindGameObjectWithTag("flowchartController").GetComponent<Flowchart>();
        talkFlowchart = GameObject.FindGameObjectWithTag("talkFlowchart").GetComponent<Flowchart>();
    }
    public static bool goToCastle
    {
        get { return talkFlowchart.GetBooleanVariable("goToCastle"); }
    }
    // Update is called once per frame
    void Update()
    {
        if (goToCastle)
        {
            SceneManager.LoadScene("girlA");
        }
    }
}
