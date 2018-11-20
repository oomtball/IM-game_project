using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class dontDestroyLab : MonoBehaviour {

    // Use this for initialization
    static GameObject instanceLab;
    private static bool cloneLab = false;
    private void Awake()
    {
        if (cloneLab == false)
        {
            Debug.Log("new one lab");
            instanceLab = GameObject.FindGameObjectWithTag("lab").GetComponent<GameObject>();
            DontDestroyOnLoad(this);
            name = "initial lab";
            cloneLab = true;
        }
        else
        {
            Debug.Log("delete one lab");
            Destroy(gameObject);
        }
    }
}
