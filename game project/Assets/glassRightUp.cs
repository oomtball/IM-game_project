using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glassRightUp : MonoBehaviour {
    public GameObject item;
    public static GameObject locust;
    public static GameObject moth;
    public Transform item2;
    public static bool tanglangInSpec = false;
    private void Awake()
    {
        locust = GameObject.Find("locust");
        moth = GameObject.Find("moth");
    }
    private void OnMouseDown()
    {
        if (tanglangGetting.gettingTanglang)
        {
            Vector3 tanglangPosition = new Vector3(-83, 195.8f, -187.91f);
            item.transform.position = tanglangPosition;
            tanglangGetting.gettingTanglang = false;
            tanglangGetting.canGetThis = false;
            tanglangInSpec = true;
            Destroy(locust);
            Destroy(moth);
        }
    }
}
