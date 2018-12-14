using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glassRightUp : MonoBehaviour {
    public GameObject item;
    public GameObject lab;
    public static GameObject locust;
    public static GameObject moth;
    public Transform item2;
    public static bool tanglangInSpec = false;
    private void Awake()
    {
        locust = GameObject.Find("Locust");
        moth = GameObject.Find("moth");
    }
    private void OnMouseDown()
    {
        if (tanglangGetting.gettingTanglang)
        {
            Vector3 tanglangPosition = new Vector3(-80.17f, 200.06f, -181.9482f);
            item.transform.rotation = Quaternion.Euler(0, 0, 0);
            item.transform.position = tanglangPosition;
            tanglangGetting.gettingTanglang = false;
            tanglangGetting.canGetThis = false;
            tanglangGetting.tanglang.transform.SetParent(lab.transform, true);
            tanglangInSpec = true;
            Destroy(locust);
            Destroy(moth);
        }
    }
}
