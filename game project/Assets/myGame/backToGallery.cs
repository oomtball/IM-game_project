using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;

public class backToGallery : MonoBehaviour {
    public static Flowchart talkFlowchart;
    public string goTo;
    public bool wantToGo = false;
    private void Awake()
    {
        talkFlowchart = GameObject.FindGameObjectWithTag("talkFlowchart").GetComponent<Flowchart>();
    }
    public static bool wantToBack
    {
        get { return talkFlowchart.GetBooleanVariable("wantToBack"); }
    }
    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.B)){
            SceneManager.LoadScene(goTo);
        }
    }
}
