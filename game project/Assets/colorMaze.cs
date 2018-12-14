using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorMaze : MonoBehaviour {
    public GameObject item;
    public static Vector3 itemPosition;
    // Use this for initialization
    private void Awake()
    {
        itemPosition = new Vector3(item.transform.position.x, item.transform.position.y + 15, item.transform.position.z);
    }
    // Update is called once per frame
    void Update () {
        if (deskDoorAButton.doorAFinish){
            item.transform.position = itemPosition;
        }
	}
}
