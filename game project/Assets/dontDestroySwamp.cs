using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class dontDestroySwamp : MonoBehaviour
{
    // Use this for initialization
    static GameObject instanceSwamp;
    private static bool cloneSwamp = false;
    private void Awake()
    {
        if (cloneSwamp == false)
        {
            Debug.Log("new one swamp");
            instanceSwamp = GameObject.FindGameObjectWithTag("swamp").GetComponent<GameObject>();
            DontDestroyOnLoad(this);
            name = "initial swamp";
            cloneSwamp = true;
        }
        else
        {
            Debug.Log("delete one swamp");
            Destroy(gameObject);
        }
    }
}
