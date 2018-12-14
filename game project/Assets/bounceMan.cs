using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class bounceMan : MonoBehaviour {
    public GameObject player;
    public Flowchart bounceBounce;
    bool isUsing = false;
    // Use this for initialization
    private void Update()
    {

        if (player.transform.position.x <= -60.3 + 20.39212 / 2 &&
            player.transform.position.x >= -60.3 - 20.39212 / 2 &&
            player.transform.position.y >= -82.39304 &&
            player.transform.position.y <= -82.3 &&
            player.transform.position.z <= -133.1 + 20.39212 / 2 &&
            player.transform.position.z >= -133.1 - 20.39212 / 2)
        {
            bounceBounce.ExecuteBlock("bounceMan");
        }

    }
    /*
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {

        if (collision.gameObject.CompareTag("Player")){
            bounceBounce.ExecuteBlock("bounceMan");
            Debug.Log("saf");
        }
    }
    */
}
