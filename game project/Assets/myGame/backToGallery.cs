using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;

public class backToGallery : MonoBehaviour {
    public static Flowchart talkFlowchart;
    public static Transform player;
    private void Awake()
    {
        talkFlowchart = GameObject.FindGameObjectWithTag("talkFlowchart").GetComponent<Flowchart>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
  
    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.B)){
            player.position = new Vector3(124.7f, 491.5f, 719.9f);
        }
    }
}
