using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class rock : MonoBehaviour {
    public GameObject player;
    public GameObject rockBall;
    public static Flowchart talkFlowchart;
    public static Flowchart flowchartManager;
    int flag = 0;
    // Use this for initialization
    void Start () {
        flowchartManager = GameObject.FindGameObjectWithTag("flowchartController").GetComponent<Flowchart>();
        talkFlowchart = GameObject.FindGameObjectWithTag("talkFlowchart").GetComponent<Flowchart>();
    }
	
	// Update is called once per frame
    public static bool back
    {
        get { return talkFlowchart.GetBooleanVariable("back"); }
    }
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")){
            /*
            Vector3 rockBallPosition = new Vector3(122, 124, 69.7f);
            rockBall.GetComponent<Rigidbody>().MovePosition(rockBallPosition);
            */
            rockBall.transform.position = new Vector3(122, 124, 69.7f);
            player.transform.position = new Vector3(57.32f, 173, -72.76f);
            if (flag == 0)
            {
                talkFlowchart.ExecuteBlock("goBack");
                flag = 1;
            }
            else if (!back)
            {
                flag = 0;
            }
        }
    }
}
