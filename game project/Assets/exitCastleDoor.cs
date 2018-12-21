using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;
public class exitCastleDoor : MonoBehaviour
{
    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    // Start is called before the first frame update
    private void Start()
    {
        flowchartManager = GameObject.FindGameObjectWithTag("flowchartController").GetComponent<Flowchart>();
        talkFlowchart = GameObject.FindGameObjectWithTag("talkFlowchart").GetComponent<Flowchart>();
    }
    public static bool goToED5
    {
        get { return talkFlowchart.GetBooleanVariable("goToED5"); }
    }
    private void Update()
    {
        if (goToED5){
            SceneManager.LoadScene("ED5");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            talkFlowchart.ExecuteBlock("goYa");
        }
    }
}
