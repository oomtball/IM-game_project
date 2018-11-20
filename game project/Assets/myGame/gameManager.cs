using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class gameManager : MonoBehaviour {

    // Use this for initialization
    public static string itemIsGetting;
    static gameManager instance;
    public static Flowchart flowchartManager;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
            name = "initial game manager";
        }
        else if (instance != null)
        {
            Destroy(gameObject);
        }
        flowchartManager = GameObject.FindGameObjectWithTag("flowchartController").GetComponent<Flowchart>();
    }
}
