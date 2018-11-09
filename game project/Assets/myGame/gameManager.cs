using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour {

    // Use this for initialization
    static gameManager instance;
    public static Flowchart flowchartManager;
    public string goToTheScene;
    private void Awake()
    {
        if (instance == null){
            instance = this;
            DontDestroyOnLoad(this);
            name = "initial game manager";
        }
        else if (instance != null){
            Destroy(gameObject);
        }
        flowchartManager = GameObject.FindGameObjectWithTag("flowchartController").GetComponent<Flowchart>();
    }
    public void Update()
    {
        //goToCh2();
    }
    public static bool talkToGirlA
    {
        get { return flowchartManager.GetBooleanVariable("girlATalk"); }
    }
    public static bool talkToGirlB
    {
        get { return flowchartManager.GetBooleanVariable("girlBTalk"); }
    }
    public static bool talkToGirlC
    {
        get { return flowchartManager.GetBooleanVariable("girlCTalk"); }
    }
    public static bool talkToBoyA
    {
        get { return flowchartManager.GetBooleanVariable("boyATalk"); }
    }
    public static bool talkToBoyB
    {
        get { return flowchartManager.GetBooleanVariable("boyBTalk"); }
    }
    private void goToCh2(){
        if (talkToGirlA && talkToGirlB && talkToGirlC && talkToBoyA && talkToBoyB){
            SceneManager.LoadScene(goToTheScene);
        }
    }
}
